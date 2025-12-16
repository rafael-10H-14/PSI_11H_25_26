using System;
using System.Collections.Generic;
using PSI_11H_25_26;

class Program
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

        // Mantém a consola aberta se executado fora de um debugger
        Console.WriteLine("\nPrima qualquer tecla para sair...");
        Console.ReadKey();
    }
}
