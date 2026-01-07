using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Ex04_ÁreasdeFormas
{
    class Program
    {
        static void Main(string[] args)
        {
            var retangulo = new Retangulo(5.0, 3.0);
            var circulo = new Circulo(2.5);

            retangulo.ExibirArea();
            circulo.ExibirArea();

            Console.WriteLine("\nUsando polimorfismo:");
            Forma[] formas = { retangulo, circulo };
            foreach (var f in formas)
            {
                f.ExibirArea();
            }
            Console.ReadKey();
        }
    }
}
