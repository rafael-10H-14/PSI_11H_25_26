using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Ex05_Escola
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Morada { get; set; }
        public Pessoa(string nome, int idade, string morada)
        {
            Nome = nome;
            Idade = idade;
            Morada = morada;
        }
        protected void ApresentarDadosPessoais()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Morada: {Morada}");
        }
        public virtual void Apresentar()
        {
            ApresentarDadosPessoais();
            Console.WriteLine(new string('-', 40));
        }
    }
}
