using Calculadora;
using CalculadoraSimples;
using System;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBoxOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpar resultado quando a operação é alterada
            textBoxResult.Clear();
            labelMessage.Text = "";
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string operand1 = textBox1.Text;
                string operand2 = textBox2.Text;
                int operationIndex = comboBoxOperation.SelectedIndex;

                double result = 0;

                // Executar a operação selecionada
                switch (operationIndex)
                {
                    case 0: // Adição
                        result = CalculatorOperations.Add(operand1, operand2);
                        break;
                    case 1: // Subtração
                        result = CalculatorOperations.Subtract(operand1, operand2);
                        break;
                    case 2: // Multiplicação
                        result = CalculatorOperations.Multiply(operand1, operand2);
                        break;
                    case 3: // Divisão
                        result = CalculatorOperations.Divide(operand1, operand2);
                        break;
                }

                // Exibir resultado
                textBoxResult.Text = result.ToString("F2");
                labelMessage.Text = "";
                labelMessage.ForeColor = System.Drawing.Color.Green;
            }
            catch (InvalidOperandException ex)
            {
                labelMessage.Text = "Erro de Operando Inválido:\n" + ex.Message;
                labelMessage.ForeColor = System.Drawing.Color.Red;
                textBoxResult.Clear();
            }
            catch (DivisionByZeroException ex)
            {
                labelMessage.Text = "Erro de Divisão por Zero:\n" + ex.Message;
                labelMessage.ForeColor = System.Drawing.Color.Red;
                textBoxResult.Clear();
            }
            catch (CalculatorException ex)
            {
                labelMessage.Text = "Erro na Calculadora:\n" + ex.Message;
                labelMessage.ForeColor = System.Drawing.Color.Red;
                textBoxResult.Clear();
            }
            catch (Exception ex)
            {
                labelMessage.Text = "Erro inesperado:\n" + ex.Message;
                labelMessage.ForeColor = System.Drawing.Color.Red;
                textBoxResult.Clear();
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBoxResult.Clear();
            labelMessage.Text = "";
            textBox1.Focus();
        }
    }
}