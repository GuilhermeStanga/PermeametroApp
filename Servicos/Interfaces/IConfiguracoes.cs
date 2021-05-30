using PermeametroApp.Entidades;
using System.Collections.Generic;

namespace PermeametroApp.Servicos.Interfaces
{
    public interface IConfiguracoes
    {
        Configuracao Carregar();
        void Salvar(Configuracao configuracao);
        List<List<HoldingRegisters>> GetHoldingRegisters(Configuracao configuracao);
    }
}
