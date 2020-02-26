using PermeametroApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermeametroApp.Servicos.Interfaces
{
    public interface IRelatorio
    {
        bool Exportar(Monitoracao monitoracoes);
    }
}
