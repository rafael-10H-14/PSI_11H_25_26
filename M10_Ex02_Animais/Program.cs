using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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
                Console.WriteLine($"{animal.Nome} tem {animal.Idade} anos.");
                animal.EmitirSom();
            }
            Console.WriteLine("\nPrima qualquer tecla para sair...");
            Console.ReadKey();
            Thread.Sleep(1000);
        }
    }
}
