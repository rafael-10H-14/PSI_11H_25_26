using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Ex01_Empresa
{
    internal class Gerente : Funcionaro
    {
        public string Departamento { get; set; }

        public Gerente(string nome, int idade, double salario, string departamento)
            : base(nome, idade, salario)
        {
            Departamento = departamento;
        }
        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Departamento: {Departamento}");
        }
    }
}
