using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Ex03_Biblioteca
{
    public class LivroFisico : Livro
    {
        public int NumeroPaginas { get; set; }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Número de páginas: {NumeroPaginas}");
        }
    }
}
