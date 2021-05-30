using PermeametroApp.Entidades;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PermeametroApp.Servicos.Interfaces;

namespace PermeametroApp
{
    public partial class Principal : Form
    {
        public IServico servico;
        public Configuracao configuracao { get; set; }
        public SerialPort serialPort { get; set; }
        private bool statusAlter { get; set; }
        private List<Monitoracao> monitoracoes { get; set; }

        public Principal(IServico servico)
        {
            this.servico = servico;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            try
            {
                configuracao = servico.Configuracoes.Carregar();
                if (configuracao != null)
                {
                    CarregarConfiguracoesDeComponentes(configuracao, true);
                }

                InicializaTimer();
                butStop.Enabled = false;
                butGerarPlanilha.Enabled = false;
                statusAlter = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            var escravos = servico.Configuracoes.GetHoldingRegisters(configuracao);

            foreach (var series in chartD.Series)
            {
                if(series.Points.Count > 0)
                    series.Points.Last().IsValueShownAsLabel = false;
            }
            foreach (var series in chartE.Series)
            {
                if (series.Points.Count > 0)
                    series.Points.Last().IsValueShownAsLabel = false;
            }

            try
            {
                IniciarComunicacaoSerial();

                foreach (List<HoldingRegisters> escravo in escravos)
                {
                    int cont = 0;
                    var dados = servico.ComunicacaoSerial.LerRegistradoresDeEscravo(escravo, serialPort);
                    escravo.ForEach(es =>
                    {
                        var x = monitoracoes.Single(m => m.registrador == es);

                        var valor = (dados[cont] * es.multiplicador + es.somador).ToString();
                        var dado = new Dado()
                        {
                            dataHora = DateTime.Now,
                            valor = double.Parse(String.Format("{0:0.0000}", valor))
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var tempoFinal = DateTime.Now;
            var tempoResposta = tempoFinal - tempoInicial;
            var tempo = Int32.Parse(configuracao.periodoAtualizacao) - (int)tempoResposta.TotalMilliseconds;
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
                IniciarComunicacaoSerial();

                butStart.Enabled = false;
                butStop.Enabled = true;
                butGerarPlanilha.Enabled = false;
                ((Control)this.tabPageConf).Enabled = false;

                while (chartD.Series.Count > 0) { chartD.Series.RemoveAt(0); }
                while (chartE.Series.Count > 0) { chartE.Series.RemoveAt(0); }
                var escravos = servico.Configuracoes.GetHoldingRegisters(configuracao);

                if (monitoracoes != null) monitoracoes.Clear();
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
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butStop_Click(object sender, EventArgs e)
        {
            try
            {
                Parar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                else
                {
                    MessageBox.Show("Dados incompletos/inválidos...");
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
            try
            {
                if (ValidaDados())
                {
                    if(configuracao == null)
                    {
                        configuracao = new Configuracao();
                    }
                    configuracao.porta = textPorta.Text;
                    configuracao.baudRate = textBaudRate.Text;
                    configuracao.dataBits = texDataBits.Text;
                    configuracao.stopBit = textStopBits.Text;
                    configuracao.paridade = textParidade.Text;
                    configuracao.periodoAtualizacao = textPeriodoAtualizacao.Text;
                    configuracao.exportarAposParar = checkExport.Checked;
                    configuracao.pastaExportacao = textPastaExportacao.Text;

                    configuracao.holdingRegisters = new List<HoldingRegisters>();
                    foreach (ListViewItem item in listView1.Items)
                    {
                        configuracao.holdingRegisters.Add(new HoldingRegisters()
                        {
                            nome = item.SubItems[0].Text,
                            idEscravo = item.SubItems[1].Text,
                            offSet = item.SubItems[2].Text,
                            modoGrafico = item.SubItems[3].Text,
                            multiplicador = float.Parse(item.SubItems[4].Text),
                            somador = float.Parse(item.SubItems[5].Text)
                        });
                    }
                    servico.Configuracoes.Salvar(configuracao);

                    servico.ComunicacaoSerial.FecharPorta(serialPort);
                    serialPort = null;
                }
                else
                {
                    MessageBox.Show("Dados incompletos/inválidos...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar configurações, " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            try
            {
                var conf = servico.Configuracoes.Carregar();
                CarregarConfiguracoesDeComponentes(conf, false);
                textRegNome.Text = "";
                textRegEscravo.Text = "";
                textRegOffset.Text = "";
                textMultiplicador.Text = "";
                textSomador.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidaDadosHoldingRegisters()
        {
            if (textRegNome.Text == string.Empty ||
                textRegEscravo.Text == string.Empty ||
                textRegOffset.Text == string.Empty ||
                textMultiplicador.Text == string.Empty ||
                textSomador.Text == string.Empty)
            {
                textRegNome.Focus();
                return false;
            }
            else
                return true;
        }

        private bool ValidaDados()
        {

            if (textPorta.Text == string.Empty ||
                textBaudRate.Text == string.Empty ||
                texDataBits.Text == string.Empty ||
                textStopBits.Text == string.Empty ||
                textParidade.Text == string.Empty ||
                textPeriodoAtualizacao.Text == string.Empty ||
                textPastaExportacao.Text == string.Empty
                )
            {
                textRegNome.Focus();
                return false;
            }
            else
                return true;
        }

        private void CarregarConfiguracoesDeComponentes(Configuracao configuracao, bool registerToo)
        {
            textPorta.Text = configuracao.porta;
            textBaudRate.Text = configuracao.baudRate;
            texDataBits.Text = configuracao.dataBits;
            textStopBits.Text = configuracao.stopBit;
            textParidade.Text = configuracao.paridade;
            textPeriodoAtualizacao.Text = configuracao.periodoAtualizacao;
            checkExport.Checked = configuracao.exportarAposParar;
            textPastaExportacao.Text = configuracao.pastaExportacao;

            if (registerToo && configuracao.holdingRegisters != null)
            {
                foreach (HoldingRegisters holdingRegister in configuracao.holdingRegisters)
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
                servico.Relatorio.Exportar(monitoracoes, configuracao, textColeta.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Acoes

        public void IniciarComunicacaoSerial()
        {
            if(serialPort == null)
            {
                serialPort = servico.ComunicacaoSerial.CriarPorta(configuracao);
            }

            if (!servico.ComunicacaoSerial.PortaEstaAberta(serialPort))
            {
                servico.ComunicacaoSerial.AbrirPorta(serialPort);
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

            servico.ComunicacaoSerial.FecharPorta(serialPort);
            serialPort = null;
        }

        #endregion
    }
}
