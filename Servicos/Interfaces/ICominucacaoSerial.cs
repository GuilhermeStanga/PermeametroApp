using PermeametroApp.Entidades;
using System.Collections.Generic;
using System.IO.Ports;

namespace PermeametroApp.Servicos.Interfaces
{
    public interface ICominucacaoSerial
    {
        SerialPort CriarPorta(Configuracao configuracao);
        void AbrirPorta(SerialPort port);
        bool PortaEstaAberta(SerialPort port);
        void FecharPorta(SerialPort port);
        ushort[] LerRegistradoresDeEscravo(List<HoldingRegisters> escravo, SerialPort port);
    }
}
