using Modbus.Device;
using Modbus.Serial;
using PermeametroApp.Entidades;
using PermeametroApp.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;

namespace PermeametroApp.Servicos
{
    public class ComunicacaoSerial : ICominucacaoSerial
    {
        public void AbrirPorta(SerialPort port)
        {
            port.Open();
        }

        public SerialPort CriarPorta(Configuracao configuracao)
        {
            var port = new SerialPort(configuracao.porta);
            port.BaudRate = Int32.Parse(configuracao.baudRate);
            port.DataBits = Int32.Parse(configuracao.dataBits);
            port.Parity = (Parity)Int32.Parse(configuracao.paridade);
            port.StopBits = (StopBits)Int32.Parse(configuracao.stopBit);
            port.ReadTimeout = 5000; //TODO: Testar
            return port;
        }

        public string FecharPorta(SerialPort port)
        {
            try
            {
                port.Close();
                port.Dispose();
                port = null;
            }catch(Exception ex)
            {
                return ex.Message;
            }
            return null;
            
        }
        
        public bool PortaEstaAberta(SerialPort port)
        {
            return port.IsOpen;
        }

        public ushort[] LerRegistradoresDeEscravo(List<HoldingRegisters> escravo, SerialPort port)
        {
            using (SerialPortAdapter adapter = new SerialPortAdapter(port))
            using (IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(adapter))
            {
                var idEscravo = escravo.First().idEscravo;
                var min = escravo.Min(x => x.offSet);
                var max = escravo.Max(x => x.offSet);
                ushort limite = ushort.Parse((Int32.Parse(max) + 1).ToString());
                ushort[] registers;
                registers = master.ReadHoldingRegisters(byte.Parse(idEscravo), ushort.Parse(min), limite);
                return registers;
            }
        }
    }
}
