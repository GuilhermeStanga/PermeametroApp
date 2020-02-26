using System.Collections.Generic;

namespace PermeametroApp.Entidades
{
    public class Monitoracao
    {
        public HoldingRegisters registrador { get; set; }
        public List<Dado> dado { get; set; }
    }
}
