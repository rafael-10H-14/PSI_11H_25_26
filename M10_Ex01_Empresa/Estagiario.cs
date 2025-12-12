using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Ex01_Empresa
{
    internal class Estagiario : Funcionaro
    {
        public int HorasPorSemana { get; set; }
        public Estagiario(string nome, int idade, double salario, int horasPorSemana)
            : base(nome, idade, salario)
        {
            HorasPorSemana = horasPorSemana;
        }
        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Horas por semana: {HorasPorSemana}");
        }
    }
}
