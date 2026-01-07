using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Ex05_Escola
{
    public class Funcionario : Pessoa
    {
        public decimal SalarioMensal { get; set; }
        public Funcionario(string nome, int idade, string morada, decimal salarioMensal)
            : base(nome, idade, morada)
        {
            SalarioMensal = salarioMensal;
        }
        public override void Apresentar()
        {
            ApresentarDadosPessoais();
            Console.WriteLine($"Cargo: Funcionário");
            Console.WriteLine($"Salário Mensal: {SalarioMensal:C}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
