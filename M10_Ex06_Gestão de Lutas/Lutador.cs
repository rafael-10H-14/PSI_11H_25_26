using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Ex06_Gestão_de_Lutas
{
    public class Lutador
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public double Peso { get; private set; }
        public int Vitorias { get; private set; }
        public int Derrotas { get; private set; }
        public int Empates { get; private set; }
        public Lutador(string nome, int idade, double peso)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            if (idade < 0) throw new ArgumentException("Idade inválida.", nameof(idade));
            Idade = idade;
            Peso = peso;
            Vitorias = 0;
            Derrotas = 0;
            Empates = 0;
        }
        public void RegistrarVitoria() => Vitorias++;
        public void RegistrarDerrota() => Derrotas++;
        public void RegistrarEmpate() => Empates++;
        protected void ApresentarDadosLutador()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Peso: {Peso:F1} kg");
            Console.WriteLine($"Vitórias: {Vitorias}");
            Console.WriteLine($"Derrotas: {Derrotas}");
            Console.WriteLine($"Empates: {Empates}");
        }
        public virtual string CategoriaDescricao => "N/D";
        public virtual void Apresentar()
        {
            ApresentarDadosLutador();
            Console.WriteLine($"Categoria: {CategoriaDescricao}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
