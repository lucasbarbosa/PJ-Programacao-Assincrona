using PJesus_Task.WF.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PJesus_Task.WF.Servicos
{
    class TarefaServico
    {
        public async static Task<List<Tarefa>> ObterTarefas(CancellationToken token = new CancellationToken())
        {
            await Task.Delay(2000);

            // ForcarErro();

            token.ThrowIfCancellationRequested();

            var lista = new List<Tarefa>
            {
                new Tarefa{ Minhatarefa = "Estudar", Estado = false },
                new Tarefa{ Minhatarefa = "Gravar vídeo", Estado = true },
                new Tarefa{ Minhatarefa = "Descansar", Estado = false },
                new Tarefa{ Minhatarefa = "Colocar séries em dia", Estado = false },
                new Tarefa{ Minhatarefa = "Assistir aquele filme", Estado = true }
            };

            return lista;
        }

        private static void ForcarErro()
        {
            throw new Exception("Ocorreu um erro com a requisição.");
        }
    }
}
