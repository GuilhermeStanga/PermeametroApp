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

        public IMonitorar Monitorar { get; }

        public IRelatorio Relatorio { get; }

        public ITimer Timer { get; }

        public Servico()
        {
            ComunicacaoSerial = new ComunicacaoSerial();
            Configuracoes = new Configuracoes();
            Monitorar = new Monitorar();
            Relatorio = new Relatorio();
            Timer = new Timer();
        }
    }
}
