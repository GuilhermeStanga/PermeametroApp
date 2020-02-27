using PermeametroApp.Entidades;

namespace PermeametroApp.Servicos.Interfaces
{
    public interface IConfiguracoes
    {
        Configuracao Carregar();
        string Salvar(Configuracao configuracao);
    }
}
