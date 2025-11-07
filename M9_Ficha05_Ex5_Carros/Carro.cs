using System;

namespace M9_Ficha05_Ex5_Carros
{
    internal class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int Cilindrada { get; set; }
        public double Velocidade { get; private set; }

        public Carro() { }

        public Carro(string marca, string modelo, string cor, int cilindrada, double velocidade = 0)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Cilindrada = cilindrada;
            Velocidade = velocidade;
        }

        public void Acelerar(double incremento)
        {
            if (incremento <= 0) return;
            Velocidade += incremento;
        }

        public void Frear(double decremento)
        {
            if (decremento <= 0) return;
            Velocidade -= decremento;
            if (Velocidade < 0) Velocidade = 0;
        }

        public override string ToString()
        {
            return $"{Marca} {Modelo} | Cor: {Cor} | {Cilindrada}cc | Velocidade: {Velocidade} km/h";
        }
    }
}   