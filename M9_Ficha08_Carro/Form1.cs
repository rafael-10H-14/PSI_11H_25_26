using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace M9_Ficha08_Carro
{
    public partial class Form1 : Form
    {
        private List<clsCarro> carros = new List<clsCarro>();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text.Trim();
            string modelo = txtModelo.Text.Trim();
            if (string.IsNullOrEmpty(marca) || string.IsNullOrEmpty(modelo))
            {
                MessageBox.Show("Preencha Marca e Modelo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtAno.Text.Trim(), out int ano))
            {
                MessageBox.Show("Ano inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(txtVelocidade.Text.Trim(), out double velocidade))
            {
                MessageBox.Show("Velocidade inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var carro = new clsCarro(marca, modelo, ano, velocidade);
            carros.Add(carro);
            txtMarca.Clear();
            txtModelo.Clear();
            txtAno.Clear();
            txtVelocidade.Clear();
            MessageBox.Show("Carro adicionado.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            lstCarros.Items.Clear();
            foreach (var c in carros)
            {
                lstCarros.Items.Add($"{c.Marca} - {c.Modelo}");
            }
        }
        private void lstCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = lstCarros.SelectedIndex;
            if (idx < 0 || idx >= carros.Count)
            {
                return;
            }
            var carro = carros[idx];
            txtMarca.Text = carro.Marca;
            txtModelo.Text = carro.Modelo;
            txtAno.Text = carro.Ano.ToString();
            txtVelocidade.Text = carro.Velocidade.ToString();
            lblAviso.Text = carro.velocidadeAcima120Km()
                ? "Velocidade superior a 120 km/h"
                : "Velocidade inferior a 120 km/h";
        }
    }
}
