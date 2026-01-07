using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Ex05_Escola
{
    public class Aluno : Pessoa
    {
        public string NumeroEstudante { get; set; }
        public Aluno(string nome, int idade, string morada, string numeroEstudante)
            : base(nome, idade, morada)
        {
            NumeroEstudante = numeroEstudante;
        }
        public override void Apresentar()
        {
            ApresentarDadosPessoais();
            Console.WriteLine($"Cargo: Aluno");
            Console.WriteLine($"Número de Estudante: {NumeroEstudante}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
