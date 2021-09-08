using MinhasTarefas.Models;
using System;
using System.Collections.Generic;

namespace MinhasTarefas.Repositories.Contracts
{
    public interface ITarefaRepository
    {
        void Sincronizacao(List<Tarefa> tarefas);
        List<Tarefa> Restauracao(ApplicationUser usuario, DateTime dataUltimaSincronizacao);
    }
}
