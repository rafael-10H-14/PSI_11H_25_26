using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M9_Ex2_Retângulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a largura do retângulo > ");
            double largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura do retângulo > ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            Retângulo retângulo = new Retângulo();
            retângulo.Largura = largura;
            retângulo.Altura = altura;
            Console.WriteLine("Área = " + retângulo.CalcularArea());
            Console.WriteLine("Perímetro = " + retângulo.CalcularPerimetro());
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
