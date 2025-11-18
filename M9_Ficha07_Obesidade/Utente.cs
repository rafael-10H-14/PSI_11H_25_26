using System;

namespace IndiceMassaCorporal
{
    public enum Genero
    {
        Masculino,
        Feminino
    }
    public class Utente
    {
        public int Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public Genero Genero { get; set; }
        public Utente()
        {
            Idade = 18;
            Peso = 50.0;
            Altura = 1.5;
            Genero = Genero.Masculino;
        }
        public Utente(int idade, double peso, double altura, Genero genero)
        {
            Idade = idade;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }
        public double CalcularIMC()
        {
            if (Altura <= 0) return 0.0;
            return Peso / (Altura * Altura);
        }
        public string ClassificacaoPeso()
        {
            double imc = CalcularIMC();
            if (imc <= 18.5)
                return "Peso Baixo";
            if (imc > 18.5 && imc <= 24.9)
                return "Peso Ideal";
            if (imc >= 25.0 && imc <= 29.9)
                return "Obesidade Leve";
            if (imc >= 30.0 && imc <= 39.9)
                return "Obesidade Moderada";
            if (imc >= 40.0)
                return "Obesidade Severa";
            return "Indeterminado";
        }
        public string RiscoSaude()
        {
            if (Idade < 18 || Idade > 65)
                return "Não aplicável (idade)";
            double imc = CalcularIMC();
            if (Genero == Genero.Masculino)
            {
                if (imc <= 17.9) return "Baixo";
                if (imc >= 18.0 && imc <= 24.9) return "Sem Risco";
                if (imc >= 25.0 && imc <= 27.7) return "Moderado";
                if (imc >= 27.8) return "Elevado";
            }
            else
            {
                if (imc >= 15.0 && imc <= 17.9) return "Baixo";
                if (imc >= 18.0 && imc <= 24.9) return "Sem Risco";
                if (imc >= 25.0 && imc <= 27.2) return "Moderado";
                if (imc >= 27.3) return "Elevado";
            }
            return "Indeterminado";
        }
    }
}