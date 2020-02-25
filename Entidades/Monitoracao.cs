using System.Collections.Generic;

namespace PermeametroApp.Entidades
{
    class Monitoracao
    {
        public HoldingRegisters registrador { get; set; }
        public List<Dado> dado { get; set; }
    }
}
