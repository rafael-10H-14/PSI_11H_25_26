using System;

namespace ClassesRetangulo
{
    public class Retangulo
    {
        public double Largura { get; private set; }
        public double Altura { get; private set; }
        public Retangulo() : this(0.0, 0.0) { }
        public Retangulo(double largura, double altura)
        {
            Largura = ValidarDimensao(largura, nameof(largura));
            Altura = ValidarDimensao(altura, nameof(altura));
        }
        private static double ValidarDimensao(double valor, string nome)
        {
            if (double.IsNaN(valor) || double.IsInfinity(valor))
                throw new ArgumentException("Valor inválido.", nome);
            if (valor < 0.0)
                throw new ArgumentOutOfRangeException(nome, "A dimensão não pode ser negativa.");
            return valor;
        }
        public double Area()
        {
            return Largura * Altura;

        }
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }
        public void Atualizar(double largura, double altura)
        {
            Largura = ValidarDimensao(largura, nameof(largura));
            Altura = ValidarDimensao(altura, nameof(altura));
        }
        public override string ToString()
        {
            return $"Largura = {Largura}, Altura = {Altura}, Área = {Area()}, Perímetro = {Perimetro()}";
        }
    }
}
