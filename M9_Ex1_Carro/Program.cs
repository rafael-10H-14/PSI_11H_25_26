using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M9_Ex1_Carro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao programa de gerenciamento de carros!");
            Carro meuCarro = new Carro("Toyota", "Corolla", "Prata", 0, 1.8);
            meuCarro.ExibirInformacoes();
            meuCarro.Acelerar(50);
            meuCarro.Parar(20);
            meuCarro.Pintar("Vermelho");
            meuCarro.ExibirInformacoes();
            Console.WriteLine("Obrigado por usar o programa de gerenciamento de carros!");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
