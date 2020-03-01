using PermeametroApp.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermeametroApp.Servicos
{
    public class Servico : IServico
    {
        public ICominucacaoSerial ComunicacaoSerial { get; }

        public IConfiguracoes Configuracoes { get; }

        public IRelatorio Relatorio { get; }

        public Servico()
        {
            ComunicacaoSerial = new ComunicacaoSerial();
            Configuracoes = new Configuracoes();
            Relatorio = new Relatorio();
        }
    }
}
