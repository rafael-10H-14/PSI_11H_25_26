using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Ex03_Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            var livroDigital = new LivroDigital
            {
                Titulo = "Introdução ao C#",
                Autor = "Maria Silva",
                Ano = 2022,
                TamanhoMB = 3.5
            };

            var livroFisico = new LivroFisico
            {
                Titulo = "Padrões de Projeto",
                Autor = "João Souza",
                Ano = 2018,
                NumeroPaginas = 412
            };

            Console.WriteLine("=== Livro Digital ===");
            livroDigital.ExibirDetalhes();

            Console.WriteLine();
            Console.WriteLine("=== Livro Físico ===");
            livroFisico.ExibirDetalhes();
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
