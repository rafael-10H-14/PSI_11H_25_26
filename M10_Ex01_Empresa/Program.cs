using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Ex01_Empresa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gerente = new Gerente("Ana Silva", 40, 8500.00, "Recursos Humanos");
            var estagiario = new Estagiario("Pedro Gomes", 21, 750.00, 20);
            gerente.ExibirInformacoes();
            Console.WriteLine();
            estagiario.ExibirInformacoes();
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
