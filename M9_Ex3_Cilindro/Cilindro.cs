using System;

namespace M9_Ex3_Cilindro
{
    public class Cilindro
    {
        public double Raio { get; }
        public double Altura { get; }

        public Cilindro(double raio, double altura)
        {
            if (double.IsNaN(raio) || double.IsInfinity(raio) || raio <= 0)
                throw new ArgumentOutOfRangeException(nameof(raio), "Raio deve ser um número finito maior que zero.");
            if (double.IsNaN(altura) || double.IsInfinity(altura) || altura <= 0)
                throw new ArgumentOutOfRangeException(nameof(altura), "Altura deve ser um número finito maior que zero.");

            Raio = raio;
            Altura = altura;
        }
        public double AreaBase()
        {
            return Math.PI * Raio * Raio;
        }
        public double AreaLateral()
        {
            return 2 * Math.PI * Raio * Altura;
        }
        public double AreaTotal()
        {
            return AreaLateral() + 2 * AreaBase();
        }
        public double Volume()
        {
            return AreaBase() * Altura;
        }
    }
}
