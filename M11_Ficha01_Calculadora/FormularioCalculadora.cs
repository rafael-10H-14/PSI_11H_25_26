using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FormularioCalculadora : Form
    {
        private string operacaoSelecionada = "";

        public FormularioCalculadora()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = "+";
            AtualizarInterfaceOperacao("Adição");
        }

        private void BtnSubtrair_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = "-";
            AtualizarInterfaceOperacao("Subtração");
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = "*";
            AtualizarInterfaceOperacao("Multiplicação");
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = "/";
            AtualizarInterfaceOperacao("Divisão");
        }

        private void AtualizarInterfaceOperacao(string nomeOperacao)
        {
            // Atualiza o título e labels de acordo com a operação
            lblOperacao.Text = nomeOperacao;
            btnCalcular.Enabled = true;
            txtOperando1.Focus();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal resultado = 0;

                switch (operacaoSelecionada)
                {
                    case "+":
                        resultado = CalculadoraOperacoes.Adicionar(txtOperando1.Text, txtOperando2.Text);
                        break;
                    case "-":
                        resultado = CalculadoraOperacoes.Subtrair(txtOperando1.Text, txtOperando2.Text);
                        break;
                    case "*":
                        resultado = CalculadoraOperacoes.Multiplicar(txtOperando1.Text, txtOperando2.Text);
                        break;
                    case "/":
                        resultado = CalculadoraOperacoes.Dividir(txtOperando1.Text, txtOperando2.Text);
                        break;
                    default:
                        throw new OperacaoInvalidaException(operacaoSelecionada);
                }

                txtResultado.Text = resultado.ToString("F2");
                MessageBox.Show($"Resultado: {resultado:F2}", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OperandoInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Erro - Operando Inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResultado.Text = "";
            }
            catch (DivisaoPorZeroException ex)
            {
                MessageBox.Show(ex.Message, "Erro - Divisão por Zero",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResultado.Text = "";
            }
            catch (CalculadoraException ex)
            {
                MessageBox.Show(ex.Message, "Erro na Calculadora",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResultado.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResultado.Text = "";
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtOperando1.Text = "";
            txtOperando2.Text = "";
            txtResultado.Text = "";
            lblOperacao.Text = "Nenhuma operação selecionada";
            operacaoSelecionada = "";
            btnCalcular.Enabled = false;
            txtOperando1.Focus();
        }
    }
}
