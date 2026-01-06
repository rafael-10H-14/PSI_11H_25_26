using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Ex03_Biblioteca
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }

        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor:  {Autor}");
            Console.WriteLine($"Ano:    {Ano}");
        }
    }
}
