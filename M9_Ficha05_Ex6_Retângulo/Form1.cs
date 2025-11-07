using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M9_Ficha05_Ex6_Retângulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnRepresentar_Click(object sender, EventArgs e)
        {
            try
            {
                double largura = double.Parse(txtLargura.Text);
                double altura = double.Parse(txtAltura.Text);
                ClassesRetangulo.Retangulo retangulo = new ClassesRetangulo.Retangulo(largura, altura);
                txtTotal.Text = retangulo.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos para largura e altura.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Erro de Intervalo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro de Argumento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
