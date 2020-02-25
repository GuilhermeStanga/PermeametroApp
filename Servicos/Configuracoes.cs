using Newtonsoft.Json;
using PermeametroApp.Entidades;
using PermeametroApp.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermeametroApp.Servicos
{
    public class Configuracoes : IConfiguracoes
    {
        public Configuracao Carregar()
        {
            Configuracao configuracoes = null;
            try
            {
                using (StreamReader r = new StreamReader(@"./Configuracoes.json"))
                {
                    string json = r.ReadToEnd();
                    configuracoes = JsonConvert.DeserializeObject<Configuracao>(json);
                    /*this.porta = configuracoes.porta;
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
                    }*/
                }
            }
            catch (Exception ex)
            {
                configuracoes = null;
                //MessageBox.Show("Erro ao carregar configurações" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            return configuracoes;
        }
    }
}
