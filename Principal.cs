using PermeametroApp.Entidades;
using Modbus.Device;
using Modbus.Serial;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PermeametroApp.Servicos.Interfaces;

namespace PermeametroApp
{
    public partial class Principal : Form
    {
        public IServico servico;
        public Configuracao configuracao { get; set; }

        public Configuracoes configuracoes { get; set; }
        public SerialPort port { get; set; }
        private bool statusAlter { get; set; }
        private List<Monitoracao> monitoracoes { get; set; }

        public Principal(IServico servico)
        {
            this.servico = servico;

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            // do stuff before Load-event is raised
            base.OnLoad(e);
            // do stuff after Load-event was raised
            configuracoes = new Configuracoes();
            configuracoes.Carregar();
            var conf = servico.Configuracoes.Carregar();
            CarregarConfiguracoesDeComponentes(conf, true);
            InicializaTimer();

            butStop.Enabled = false;
            butGerarPlanilha.Enabled = false;
            statusAlter = false;

            
        }


        #region Timer

        private void InicializaTimer()
        {
            timer1.Enabled = false;
            timer1.Interval = 1; //Para iniciar imediatamente
            timer1.Tick += new EventHandler(Timer1_Tick);
        }

        private void Timer1_Tick(object Sender, EventArgs e)
        {
            timer1.Stop();
            var tempoInicial = DateTime.Now;
            var escravos = configuracoes.holdingRegisters
                                        .Select((x, i) => new { Index = i, Value = x })
                                        .GroupBy(x => x.Value.idEscravo)
                                        .Select(x => x.Select(v => v.Value).ToList())
                                        .ToList();
            try
            {
                AbrirPorta();
                var adapter = new SerialPortAdapter(port);
                using (IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(adapter))
                {
                    foreach (List<HoldingRegisters> escravo in escravos)
                    {
                        var idEscravo = escravo.First().idEscravo;
                        var min = escravo.Min(x => x.offSet);
                        var max = escravo.Max(x => x.offSet);
                        ushort limite = ushort.Parse((Int32.Parse(max) + 1).ToString());
                        int cont = 0;
                        ushort[] registers;
                        registers = master.ReadHoldingRegisters(byte.Parse(idEscravo), ushort.Parse(min), limite);

                        foreach (var series in chartD.Series)
                        {
                            foreach (var point in series.Points)
                            {
                                point.IsValueShownAsLabel = false;
                            }
                        }
                        foreach (var series in chartE.Series)
                        {
                            foreach (var point in series.Points)
                            {
                                point.IsValueShownAsLabel = false;
                            }
                        }

                        escravo.ForEach(es =>
                        {
                            var x = monitoracoes.
                                Where(m => m.registrador == es).Single();

                            var dado = new Dado()
                            {
                                dataHora = DateTime.Now,
                                valor = registers[cont] * es.multiplicador + es.somador
                            };

                            x.dado.Add(dado);

                            if (es.modoGrafico == "Esquerdo")
                            {
                                chartE.Series[es.nome].Points.Add(dado.valor).IsValueShownAsLabel = true;
                            }
                            else if (es.modoGrafico == "Direito")
                            {
                                chartD.Series[es.nome].Points.Add(dado.valor).IsValueShownAsLabel = true;
                            }
                            cont++;
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var tempoFinal = DateTime.Now;
            var tempoResposta = tempoFinal - tempoInicial;
            var tempo = Int32.Parse(configuracoes.periodoAtualizacao) - (int)tempoResposta.TotalMilliseconds;
            timer1.Interval = tempo <= 0 ? 1 : tempo;
            timer1.Start();
        }

        #endregion

        #region Botoes Monitorar

        private void butStart_Click(object sender, EventArgs e)
        {
            if (textColeta.Text == "")
            {
                MessageBox.Show("Informe um nome para a coleta!");
                return;
            }
            try
            {
                AbrirPorta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            butStart.Enabled = false;
            butStop.Enabled = true;
            butGerarPlanilha.Enabled = false;
            ((Control)this.tabPageConf).Enabled = false;

            try
            {
                while (chartD.Series.Count > 0) { chartD.Series.RemoveAt(0); }
                while (chartE.Series.Count > 0) { chartE.Series.RemoveAt(0); }
                var escravos = configuracoes.holdingRegisters
                                 .Select((x, i) => new { Index = i, Value = x })
                                 .GroupBy(x => x.Value.idEscravo)
                                 .Select(x => x.Select(v => v.Value).ToList())
                                 .ToList();
                
                if(monitoracoes != null) monitoracoes.Clear();
                monitoracoes = new List<Monitoracao>();
                foreach (List<HoldingRegisters> escravo in escravos)
                {
                    escravo.ForEach(es =>
                    {
                        monitoracoes.Add(new Monitoracao()
                        {
                            registrador = es,
                            dado = new List<Dado>()
                        });

                        if (es.modoGrafico == "Esquerdo")
                        {
                            chartE.Series.Add(es.nome);
                            chartE.Series[es.nome].ChartType = SeriesChartType.Spline;
                        }
                        else if (es.modoGrafico == "Direito")
                        {
                            chartD.Series.Add(es.nome);
                            chartD.Series[es.nome].ChartType = SeriesChartType.Spline;
                        }
                    });
                }

                /*monitoracoes.ForEach(m =>
                {
                    relatorio.Append(m.registrador.nome);
                    relatorio.Append(";Tempo;");
                });*/
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butStop_Click(object sender, EventArgs e)
        {
            Parar();
        }

        private void butGerarPlanilha_Click(object sender, EventArgs e)
        {
            ExportarRelatorio();
            textColeta.Text = "";
        }

        #endregion

        #region Configurações

        private void btnRegAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaDadosHoldingRegisters())
                {
                    string[] row = { textRegNome.Text, textRegEscravo.Text, textRegOffset.Text, comboGrafico.Text };
                    var listViewItem = new ListViewItem(row);

                    if (statusAlter)
                    {
                        listView1.SelectedItems[0].SubItems[0].Text = textRegNome.Text;
                        listView1.SelectedItems[0].SubItems[1].Text = textRegEscravo.Text;
                        listView1.SelectedItems[0].SubItems[2].Text = textRegOffset.Text;
                        listView1.SelectedItems[0].SubItems[3].Text = comboGrafico.Text;
                        listView1.SelectedItems[0].SubItems[4].Text = textMultiplicador.Text;
                        listView1.SelectedItems[0].SubItems[5].Text = textSomador.Text;
                    }
                    else
                    {
                        listView1.Items.Add(listViewItem);
                    }

                    textRegNome.Text = "";
                    textRegEscravo.Text = "";
                    textRegOffset.Text = "";
                    comboGrafico.Text = "";
                    textMultiplicador.Text = "";
                    textSomador.Text = "";

                    statusAlter = false;
                    btnRegAdd.Text = "Adicionar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    textRegNome.Text = listView1.SelectedItems[0].SubItems[0].Text;
                    textRegEscravo.Text = listView1.SelectedItems[0].SubItems[1].Text;
                    textRegOffset.Text = listView1.SelectedItems[0].SubItems[2].Text;
                    comboGrafico.Text = listView1.SelectedItems[0].SubItems[3].Text;
                    textMultiplicador.Text = listView1.SelectedItems[0].SubItems[4].Text;
                    textSomador.Text = listView1.SelectedItems[0].SubItems[5].Text;

                    statusAlter = true;
                    btnRegAdd.Text = "Alterar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaDados())
            {
                configuracoes.porta = textPorta.Text;
                configuracoes.baudRate = textBaudRate.Text;
                configuracoes.dataBits = texDataBits.Text;
                configuracoes.stopBit = textStopBits.Text;
                configuracoes.paridade = textParidade.Text;
                configuracoes.periodoAtualizacao = textPeriodoAtualizacao.Text;
                configuracoes.exportarAposParar = checkExport.Checked;
                configuracoes.pastaExportacao = textPastaExportacao.Text;

                configuracoes.holdingRegisters = new List<HoldingRegisters>();

                foreach (ListViewItem item in listView1.Items)
                {
                    configuracoes.holdingRegisters.Add(new HoldingRegisters()
                    {
                        nome = item.SubItems[0].Text,
                        idEscravo = item.SubItems[1].Text,
                        offSet = item.SubItems[2].Text,
                        modoGrafico = item.SubItems[3].Text,
                        multiplicador = Int32.Parse(item.SubItems[4].Text),
                        somador = Int32.Parse(item.SubItems[5].Text)
                    });
                }

                configuracoes.Salvar();
            }
        }

        private void btnRegExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirma exclusão deste Data Point ?", "Confirma Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    listView1.Items[listView1.SelectedItems[0].Index].Remove();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir o usuário." + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                statusAlter = false;
                btnRegAdd.Text = "Adicionar";

                textRegNome.Text = "";
                textRegEscravo.Text = "";
                textRegOffset.Text = "";
                textMultiplicador.Text = "";
                textSomador.Text = "";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CarregarConfiguracoesDeComponentes(false);
            textRegNome.Text = "";
            textRegEscravo.Text = "";
            textRegOffset.Text = "";
            textMultiplicador.Text = "";
            textSomador.Text = "";
        }

        private bool ValidaDadosHoldingRegisters()
        {
            if (textRegNome.Text == string.Empty |
                textRegEscravo.Text == string.Empty |
                textRegOffset.Text == string.Empty |
                textMultiplicador.Text == string.Empty |
                textSomador.Text == string.Empty)
            {
                MessageBox.Show("Dados incompletos/inválidos...");
                textRegNome.Focus();
                return false;
            }
            else
                return true;
        }

        private bool ValidaDados()
        {

            if (textPorta.Text == string.Empty |
                textBaudRate.Text == string.Empty |
                texDataBits.Text == string.Empty |
                textStopBits.Text == string.Empty |
                textParidade.Text == string.Empty |
                textPeriodoAtualizacao.Text == string.Empty |
                textPastaExportacao.Text == string.Empty
                )
            {
                MessageBox.Show("Dados incompletos/inválidos...");
                textRegNome.Focus();
                return false;
            }
            else
                return true;
        }

        private void CarregarConfiguracoesDeComponentes(Configuracao configuracao, bool registerToo)
        {
            textPorta.Text = configuracoes.porta;
            textBaudRate.Text = configuracoes.baudRate;
            texDataBits.Text = configuracoes.dataBits;
            textStopBits.Text = configuracoes.stopBit;
            textParidade.Text = configuracoes.paridade;
            textPeriodoAtualizacao.Text = configuracoes.periodoAtualizacao;
            checkExport.Checked = configuracoes.exportarAposParar;
            textPastaExportacao.Text = configuracoes.pastaExportacao;

            if (registerToo)
            {
                foreach (HoldingRegisters holdingRegister in configuracoes.holdingRegisters)
                {
                    string[] row = {
                            holdingRegister.nome,
                            holdingRegister.idEscravo,
                            holdingRegister.offSet,
                            holdingRegister.modoGrafico,
                            holdingRegister.multiplicador.ToString(),
                            holdingRegister.somador.ToString()
                            };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                }
            }
        }

        #endregion

        #region Relatorio

        public void ExportarRelatorio()
        {
            try
            {
                string relatorio = "";
                monitoracoes.ForEach(m =>
                {
                    relatorio += m.registrador.nome + ", Tempo,";
                });
                relatorio = relatorio.Remove(relatorio.Length - 1);
                relatorio += Environment.NewLine;

                int cont = 0;
                monitoracoes.ForEach(m =>
                {
                    m.dado.ForEach(d =>
                    {
                        var ant = cont - 1;
                        var strAnt = "%%" + ant;
                        var index2 = relatorio.IndexOf("%%" + ant);
                        if (index2 > 0)
                        {
                            var tmp = d.valor + "," + d.dataHora + ",%%" + cont;
                            var size = "%%" + ant;
                            var relatorioTmp = relatorio.Substring(0, index2) + tmp + relatorio.Substring(index2 + ("%%" + ant).Length);
                            relatorio = relatorioTmp;
                        }
                        else
                        {
                            relatorio += d.valor + "," + d.dataHora + ",%%" + cont;
                        }
                    });
                    cont++;
                });

                relatorio = relatorio.Replace("%%" + --cont, Environment.NewLine);
                var arquivo = configuracoes.pastaExportacao + "\\" + textColeta.Text + ".csv";
                File.WriteAllText(arquivo, relatorio);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Acoes

        public void AbrirPorta()
        {
            if (port == null)
            {
                port = new SerialPort(configuracoes.porta);
                port.BaudRate = Int32.Parse(configuracoes.baudRate);
                port.DataBits = Int32.Parse(configuracoes.dataBits);
                port.Parity = (Parity)Int32.Parse(configuracoes.paridade);
                port.StopBits = (StopBits)Int32.Parse(configuracoes.stopBit);
                port.ReadTimeout = 5000; //TODO: Testar
            }
            if (!port.IsOpen)
            {
                port.Open();
            }
        }

        public void Parar()
        {
            butStop.Enabled = false;
            butStart.Enabled = true;
            butGerarPlanilha.Enabled = true;
            timer1.Enabled = false;
            ((Control)this.tabPageConf).Enabled = true;

            if (checkExport.Checked)
            {
                ExportarRelatorio();
                textColeta.Text = "";
            }
            port.Close();
            port.Dispose();
            port = null;
        }

        #endregion
    }
}
