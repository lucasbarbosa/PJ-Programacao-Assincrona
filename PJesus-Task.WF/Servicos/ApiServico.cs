using PJesus_Task.WF.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PJesus_Task.WF.Servicos
{
    class ApiServico
    {
        public static IEnumerable<Palestra> ObterPalestras()
        {
            Thread.Sleep(5000);
            var palestras = new[]
            {
                new Palestra{ TituloPalestra = "Xamarin Avançado" },
                new Palestra{ TituloPalestra = "Xamarin Iniciante" },
                new Palestra{ TituloPalestra = "Usando EF corretamente" },
                new Palestra{ TituloPalestra = "Definindo arquitetura do projeto" }
            };
            return palestras;
        }

        public static Task<IEnumerable<Palestra>> ObterPalestrasAwait()
        {
            return Task.Factory.StartNew<IEnumerable<Palestra>>(() => {
                Thread.Sleep(5000);
                var palestras = new[]
                {
                    new Palestra{ TituloPalestra = "Xamarin Avançado" },
                    new Palestra{ TituloPalestra = "Xamarin Iniciante" },
                    new Palestra{ TituloPalestra = "Usando EF corretamente" },
                    new Palestra{ TituloPalestra = "Definindo arquitetura do projeto" }
                };
                return palestras;
            });
        }

        public static IEnumerable<Palestrante> ObterPalestrantes()
        {
            Thread.Sleep(3000);
            var palestrantes = new[]
            {
                new Palestrante{ NomePalestrante = "Jefferson" },
                new Palestrante{ NomePalestrante = "Pedro" },
                new Palestrante{ NomePalestrante = "Cleidson" },
                new Palestrante{ NomePalestrante = "Zé" }
            };
            return palestrantes;
        }

        public static Task<IEnumerable<Palestrante>> ObterPalestrantesAwait()
        {
            return Task.Factory.StartNew<IEnumerable<Palestrante>>(() => {
                Thread.Sleep(3000);
                var palestrantes = new[]
                {
                    new Palestrante{ NomePalestrante = "Jefferson" },
                    new Palestrante{ NomePalestrante = "Pedro" },
                    new Palestrante{ NomePalestrante = "Cleidson" },
                    new Palestrante{ NomePalestrante = "Zé" }
                };
                return palestrantes;
            });
        }
    }
}
