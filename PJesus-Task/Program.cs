using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PJesus_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tarefa
            var t1 = Task.Factory.StartNew(() => {
                Console.WriteLine("Tarefa 1 iniciada.");
                Thread.Sleep(2000);
                Console.WriteLine("Tarefa 1 concluída.");
            });
            var t2 = Task.Factory.StartNew(() => Tarefa(2, 1500));
            var t3 = Task.Factory.StartNew(() => Tarefa(3, 2500));

            // Executa o próximo comando depois de finalizar a lista de tarefas
            var listaTarefas = new List<Task> { t1, t2, t3 };
            Task.WaitAll(listaTarefas.ToArray());
            
            // Get 1
            var recebe = Get();
            string resultado = recebe.Result;
            Console.WriteLine(resultado);

            // Get 2
            Get().ContinueWith(t => Console.WriteLine(t.Result)).Wait();
            
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
		
        static void Tarefa(int id, int delay)
        {
            Console.WriteLine($"Tarefa {id} iniciada.");
            Thread.Sleep(delay);
            Console.WriteLine($"Tarefa {id} concluída.");
        }

        static async Task<string> Get()
        {
            await Task.Delay(2000);
            return "Olá mundo!";
        }
    }
}
