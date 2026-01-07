using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Ex04_ÁreasdeFormas
{
    public class Circulo : Forma
    {
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }

        public override void ExibirArea()
        {
            Console.WriteLine($"Círculo (Raio = {Raio}) -> Área: {CalcularArea():F2}");
        }
    }
}
