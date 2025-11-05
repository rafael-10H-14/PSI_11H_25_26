using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M9_Ex1_Carro
{
    internal class Carro
    {
        // Atributos
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public double Cilindrada { get; set; }
        public double Velocidade { get; private set; }
        // Construtor
        public Carro(string marca, string modelo, string cor, double velocidade, double cilindrada)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Cilindrada = cilindrada;
            Velocidade = velocidade;
        }
        public void Acelerar(double incremento)
        {
            Velocidade += incremento;
            Console.WriteLine($"O carro acelerou {incremento} km/h. Velocidade atual: {Velocidade} km/h.");
        }
        public void Parar(double decremento)
        {
            Velocidade -= decremento;
            if (Velocidade < 0)
            {
                Velocidade = 0;
            }
            Console.WriteLine($"O carro desacelerou {decremento} km/h. Velocidade atual: {Velocidade} km/h.");
        }
        public void Pintar(string novaCor)
        {
            Cor = novaCor;
            Console.WriteLine($"O carro foi pintado de {novaCor}.");
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine("Informações do Carro:");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Cilindrada: {Cilindrada} L");
            Console.WriteLine($"Velocidade Atual: {Velocidade} km/h");
        }
    }
}
