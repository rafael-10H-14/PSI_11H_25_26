using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Ex02_Animais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animais = new List<Animal>
            {
                new Cao("Rex", 5),
                new Gato("Mimi", 3),
                new Cao("Bolt", 2),
                new Gato("Whiskers", 1)
            };
            foreach (var animal in animais)
            {
                animal.EmitirSom();
            }
            Console.WriteLine("\nPrima qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
