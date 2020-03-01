namespace PermeametroApp.Servicos.Interfaces
{
    public interface IServico
    {
        ICominucacaoSerial ComunicacaoSerial { get; }
        IConfiguracoes Configuracoes { get; }
        IRelatorio Relatorio { get; }
    }
}
