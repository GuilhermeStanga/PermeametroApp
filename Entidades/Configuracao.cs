using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermeametroApp.Entidades
{
    public class Configuracao
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
    }
}
