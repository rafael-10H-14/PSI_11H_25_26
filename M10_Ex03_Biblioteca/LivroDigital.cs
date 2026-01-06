using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Ex03_Biblioteca
{
    public class LivroDigital : Livro
    {
        public double TamanhoMB { get; set; }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Tamanho: {TamanhoMB} MB");
        }
    }
}
