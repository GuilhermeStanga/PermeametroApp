﻿using PermeametroApp.Entidades;
using System.Collections.Generic;

namespace PermeametroApp.Servicos.Interfaces
{
    public interface IRelatorio
    {
        void Exportar(List<Monitoracao> monitoracoes, Configuracao configuracao, string nomeArquivo);
    }
}
