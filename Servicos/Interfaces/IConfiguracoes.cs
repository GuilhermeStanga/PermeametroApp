using PermeametroApp.Entidades;

namespace PermeametroApp.Servicos.Interfaces
{
    public interface IConfiguracoes
    {
        Configuracao Carregar();
        bool Salvar(Configuracao configuracao);
    }
}
