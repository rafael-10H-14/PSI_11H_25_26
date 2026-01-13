using M10_Avaliação_Gestão_de_Clientes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GestaoClientes
{
    public partial class MainForm : Form
    {
        // Lista do tipo List<Cliente>
        private List<Cliente> clientes = new List<Cliente>();

        public MainForm()
        {
            InitializeComponent();
        }

        // Evento do botão Adicionar
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validação de campos vazios
                if (string.IsNullOrWhiteSpace(txtId.Text) ||
                    string.IsNullOrWhiteSpace(txtNome.Text) ||
                    string.IsNullOrWhiteSpace(txtTipo.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Conversão do ID (tratamento de tipos inválidos)
                if (!int.TryParse(txtId.Text.Trim(), out int id))
                {
                    MessageBox.Show("ID inválido. Insira um número inteiro.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtId.Focus();
                    return;
                }

                string nome = txtNome.Text.Trim();
                string tipo = txtTipo.Text.Trim();

                // Criar instância de ClienteRegular (classe derivada)
                ClienteRegular cr = new ClienteRegular(id, nome, tipo);

                // Adiciona à lista
                clientes.Add(cr);

                // Mostra na ListBox informações do cliente (chamando métodos da classe)
                string display = $"ID: {cr.IdCliente} ({cr.ParOuImpar()}) - Nome: {cr.Nome} - Chars(nome): {cr.NumeroCaracteresNome()} - Tipo: {cr.TipoCliente}";
                lstClientes.Items.Add(display);

                // Limpa campos
                txtId.Clear();
                txtNome.Clear();
                txtTipo.Clear();
                txtId.Focus();
            }
            catch (Exception ex)
            {
                // Tratamento de erro genérico
                MessageBox.Show("Ocorreu um erro ao adicionar o cliente:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento do botão Média de caracteres
        private void btnMediaCaracteres_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientes.Count == 0)
                {
                    MessageBox.Show("A lista de clientes está vazia.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Chama o método NumeroCaracteresNome de cada cliente (polimorfismo em ação)
                double media = clientes.Average(c => c.NumeroCaracteresNome());
                MessageBox.Show($"Média de caracteres do nome: {media:F2}", "Média", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular a média:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento do botão Maior número par
        private void btnMaiorPar_Click(object sender, EventArgs e)
        {
            try
            {
                var pares = clientes.Where(c => c.IdCliente % 2 == 0).Select(c => c.IdCliente);
                if (!pares.Any())
                {
                    MessageBox.Show("Não há IDs pares na lista.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int maiorPar = pares.Max();
                MessageBox.Show($"Maior ID par na lista: {maiorPar}", "Maior Par", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular o maior ID par:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}