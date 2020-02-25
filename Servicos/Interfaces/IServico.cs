using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermeametroApp.Servicos.Interfaces
{
    public interface IServico
    {
        ICominucacaoSerial ComunicacaoSerial { get; }
        IConfiguracoes Configuracoes { get; }
        IMonitorar Monitorar { get; }
        IRelatorio Relatorio { get; }
        ITimer Timer { get; }
    }
}
