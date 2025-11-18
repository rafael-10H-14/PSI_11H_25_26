using System;
using System.Globalization;
using System.Windows.Forms;

namespace M9_Ficha07_Obesidade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxIdade.Text.Trim(), out int idade))
            {
                MessageBox.Show("Introduza uma idade válida (número inteiro).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxIdade.Focus();
                return;
            }
            Genero genero = radioButtonMasculino.Checked ? Genero.Masculino : Genero.Feminino;
            double peso = (double)numericUpDownPeso.Value;
            double altura = (double)numericUpDownAltura.Value;
            Utente utente = new Utente(idade, peso, altura, genero);
            double imc = utente.CalcularIMC();
            string classificacao = utente.ClassificacaoPeso();
            string risco = utente.RiscoSaude();
            labelIMC.Text = imc.ToString("0.00", CultureInfo.GetCultureInfo("pt-PT"));
            labelClassificacao.Text = classificacao;
            labelRisco.Text = risco;
        }
        private void buttonRepor_Click(object sender, EventArgs e)
        {
            radioButtonMasculino.Checked = true;
            textBoxIdade.Text = "18";
            numericUpDownPeso.Value = 50;
            numericUpDownAltura.Value = 1.50m;
            labelIMC.Text = "";
            labelClassificacao.Text = "";
            labelRisco.Text = "";
        }

        private void labelIMC_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownPeso_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    public enum Genero
    {
        Masculino,
        Feminino
    }
    public class Utente
    {
        public int Idade { get; }
        public double Peso { get; }
        public double Altura { get; }
        public Genero Genero { get; }
        public Utente(int idade, double peso, double altura, Genero genero)
        {
            if (idade <= 0 || idade > 120)
                throw new ArgumentOutOfRangeException(nameof(idade), "Idade deve ser um inteiro entre 1 e 120.");
            if (double.IsNaN(peso) || double.IsInfinity(peso) || peso <= 0)
                throw new ArgumentOutOfRangeException(nameof(peso), "Peso deve ser um número finito maior que zero.");
            if (double.IsNaN(altura) || double.IsInfinity(altura) || altura <= 0)
                throw new ArgumentOutOfRangeException(nameof(altura), "Altura deve ser um número finito maior que zero.");
            Idade = idade;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }
        public double CalcularIMC()
        {
            return Peso / (Altura * Altura);
        }
        public string ClassificacaoPeso()
        {
            double imc = CalcularIMC();
            if (imc < 18.5) return "Baixo peso";
            if (imc < 25.0) return "Peso normal";
            if (imc < 30.0) return "Excesso de peso";
            if (imc < 35.0) return "Obesidade (Grau I)";
            if (imc < 40.0) return "Obesidade (Grau II)";
            return "Obesidade (Grau III)";
        }
        public string RiscoSaude()
        {
            double imc = CalcularIMC();
            string risco;
            if (imc < 18.5)
                risco = "Baixo (possível risco por subnutrição)";
            else if (imc < 25.0)
                risco = "Baixo";
            else if (imc < 30.0)
                risco = "Moderado";
            else if (imc < 35.0)
                risco = "Elevado";
            else if (imc < 40.0)
                risco = "Muito elevado";
            else
                risco = "Extremamente elevado";
            if (Idade >= 65)
                risco += " — risco aumentado pela idade";
            return risco;
        }
    }
}
