using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Ex02_Animais
{
    public class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public virtual void EmitirSom()
        {
            Console.WriteLine($"{Nome} emite um som.");
        }
    }
    public class Cao : Animal
    {
        public Cao(string nome, int idade) : base(nome, idade) { }
        public override void EmitirSom()
        {
            Console.WriteLine("O cão ladra: Au Au!");
        }
    }
    public class Gato : Animal
    {
        public Gato(string nome, int idade) : base(nome, idade) { }
        public override void EmitirSom()
        {
            Console.WriteLine("O gato mia: Miau!");
        }
    }
}
