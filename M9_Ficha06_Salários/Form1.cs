using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M9_Ficha06_Salários
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obter o salário bruto
            double salarioBruto = 0;
            double.TryParse(txtSalarioBruto.Text, out salarioBruto);

            // Calcular o desconto da Segurança Social (20%)
            double descontoSS = salarioBruto * 0.20;

            // Calcular o desconto do IRS (15% sobre o que exceder 1500€)
            double descontoIRS = 0;
            if (salarioBruto > 1500)
            {
                descontoIRS = (salarioBruto - 1500) * 0.15;
            }

            // Calcular o salário líquido
            double salarioLiquido = salarioBruto - descontoSS - descontoIRS;

            // Obter o nome e apelido
            string nome = txtNome.Text;
            string apelido = txtApelido.Text;

            // Exibir os resultados
            txtDescontoSS.Text = descontoSS.ToString("F2");
            txtDescontoIRS.Text = descontoIRS.ToString("F2");
            txtSalarioLiquido.Text = salarioLiquido.ToString("F2");
            lblNomeCompletoValor.Text = $"{nome} {apelido}";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar todos os campos
            txtNome.Clear();
            txtApelido.Clear();
            txtSalarioBruto.Clear();
            txtDescontoSS.Clear();
            txtDescontoIRS.Clear();
            txtSalarioLiquido.Clear();
            lblNomeCompletoValor.Text = "";
            txtNome.Focus();
        }
    }
}
