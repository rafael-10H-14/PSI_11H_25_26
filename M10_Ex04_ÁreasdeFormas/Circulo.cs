using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Ex04_ÁreasdeFormas
{
    public class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }
        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }
        public override double CalcularArea()
        {
            return Largura * Altura;
        }
        public override void ExibirArea()
        {
            Console.WriteLine($"Retângulo (Largura = {Largura}, Altura = {Altura}) -> Área: {CalcularArea():F2}");
        }
    }
}
