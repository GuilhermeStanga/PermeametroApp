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
    public class Relatorio : IRelatorio
    {
        public string Exportar(List<Monitoracao> monitoracoes, Configuracao configuracao, string nomeArquivo)
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
                var arquivo = configuracao.pastaExportacao + "\\" + nomeArquivo + ".csv";
                File.WriteAllText(arquivo, relatorio);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return null;
        }
    }
}
