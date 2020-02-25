using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PermeametroApp
{
    public class Configuracoes
    {
        public string porta { get; set; }
        public string baudRate { get; set; }
        public string dataBits { get; set; }
        public string stopBit { get; set; }
        public string paridade { get; set; }
        public string periodoAtualizacao { get; set; }
        public bool exportarAposParar { get; set; }
        public string pastaExportacao { get; set; }

        public List<HoldingRegisters> holdingRegisters { get; set; }

        public void Carregar()
        {
            try
            {
                using (StreamReader r = new StreamReader(@"./Configuracoes.json"))
                {
                    string json = r.ReadToEnd();
                    Configuracoes configuracoes = JsonConvert.DeserializeObject<Configuracoes>(json);
                    this.porta = configuracoes.porta;
                    this.baudRate = configuracoes.baudRate;
                    this.dataBits = configuracoes.dataBits;
                    this.stopBit = configuracoes.stopBit;
                    this.paridade = configuracoes.paridade;
                    this.periodoAtualizacao = configuracoes.periodoAtualizacao;
                    this.exportarAposParar = configuracoes.exportarAposParar;
                    this.pastaExportacao = configuracoes.pastaExportacao;

                    this.holdingRegisters = new List<HoldingRegisters>();

                    foreach (var holdingRegister in configuracoes.holdingRegisters)
                    {
                        this.holdingRegisters.Add(new HoldingRegisters()
                        {
                            nome = holdingRegister.nome,
                            idEscravo = holdingRegister.idEscravo,
                            offSet = holdingRegister.offSet,
                            modoGrafico = holdingRegister.modoGrafico,
                            multiplicador = holdingRegister.multiplicador,
                            somador = holdingRegister.somador
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar configurações" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Salvar()
        {
            try
            {
                using (StreamWriter file = File.CreateText(@"./Configuracoes.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar configurações" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
