using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Ex05_Escola
{
    public class Professor : Funcionario
    {
        public string Disciplina { get; set; }
        public Professor(string nome, int idade, string morada, decimal salarioMensal, string disciplina)
            : base(nome, idade, morada, salarioMensal)
        {
            Disciplina = disciplina;
        }
        public override void Apresentar()
        {
            ApresentarDadosPessoais();
            Console.WriteLine($"Cargo: Professor");
            Console.WriteLine($"Salário Mensal: {SalarioMensal:C}");
            Console.WriteLine($"Disciplina: {Disciplina}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
