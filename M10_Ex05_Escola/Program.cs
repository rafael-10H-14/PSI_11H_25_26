using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Ex05_Escola
{
    class Program
    {
        static void Main(string[] args)
        {
            var aluno = new Aluno("Ana Silva", 17, "Rua das Flores, 12", "A2023001");
            var funcionario = new Funcionario("João Costa", 45, "Av. Central, 88", 1300.50m);
            var professor = new Professor("Marta Lopes", 39, "Rua do Limoeiro, 5", 2100.00m, "Matemática");
            List<Pessoa> pessoas = new List<Pessoa> { aluno, funcionario, professor };
            Console.WriteLine("=== Apresentação dos elementos da escola ===\n");
            foreach (var p in pessoas)
            {
                p.Apresentar();
            }
            Console.WriteLine("Pressione uma tecla para sair...");
            Console.ReadKey();
        }
    }
}
