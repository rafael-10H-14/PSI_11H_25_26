using System;

namespace M9_Ficha08_Carro
{
    public class clsCarro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Velocidade { get; set; }
        public clsCarro(string marca, string modelo, int ano, double velocidade)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Velocidade = velocidade;
        }
        public bool velocidadeAcima120Km()
        {
            return Velocidade > 120.0;
        }
    }
}
