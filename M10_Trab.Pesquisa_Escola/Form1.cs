using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M10_Trab.Pesquisa_Escola
{
    public partial class MainForm : Form
    {
        // Lista global de escolas
        private List<clsEscola> listaEscolas = new List<clsEscola>();

        public MainForm()
        {
            InitializeComponent();
            SetButtonsInitialState();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Método de configuração das ListViews — chamado no Load do formulário
            ConfigurarListViews();

            // Adicionar dados de exemplo (opcional)
            CarregarDadosExemplo();

            // Atualizar a listagem inicial de escolas
            AtualizarListViewEscolas();
        }

        #region Configuração e Dados exemplo
        private void ConfigurarListViews()
        {
            // Configura colunas das ListViews (pode também ser feito no Designer)
            listViewEscolas.Columns.Clear();
            listViewEscolas.Columns.Add("Código", 100, HorizontalAlignment.Left);
            listViewEscolas.Columns.Add("Nome Escola", 320, HorizontalAlignment.Left);

            listViewCursos.Columns.Clear();
            listViewCursos.Columns.Add("Código Curso", 140, HorizontalAlignment.Left);
            listViewCursos.Columns.Add("Nome Curso", 260, HorizontalAlignment.Left);

            listViewEscolas.View = View.Details;
            listViewCursos.View = View.Details;
        }

        private void CarregarDadosExemplo()
        {
            var e1 = new clsEscola("E001", "Escola Secundária A");
            e1.AdicionarCurso(new clsCurso("C101", "Matemática"));
            e1.AdicionarCurso(new clsCurso("C102", "Física"));

            var e2 = new clsEscola("E002", "Escola Secundária B");
            e2.AdicionarCurso(new clsCurso("C201", "Português"));

            listaEscolas.Add(e1);
            listaEscolas.Add(e2);
        }
        #endregion

        #region Utilitários de Busca/Listagem
        private clsEscola EncontrarEscola(string codigoEscola)
        {
            if (string.IsNullOrWhiteSpace(codigoEscola)) return null;
            return listaEscolas.FirstOrDefault(e => e.Codigo == codigoEscola.Trim());
        }

        private void AtualizarListViewEscolas()
        {
            listViewEscolas.Items.Clear();
            foreach (var e in listaEscolas)
            {
                var lvi = new ListViewItem(new[] { e.Codigo, e.Nome });
                listViewEscolas.Items.Add(lvi);
            }
        }

        private void ListarCursosDaEscola(clsEscola escola)
        {
            listViewCursos.Items.Clear();
            if (escola == null) return;
            foreach (var c in escola.Cursos)
            {
                var lvi = new ListViewItem(new[] { c.Codigo, c.Nome });
                listViewCursos.Items.Add(lvi);
            }
        }
        #endregion

        #region Gestão Botões / Campos
        private void SetButtonsInitialState()
        {
            btnNovaEscola.Enabled = true;
            btnGravaDados.Enabled = false;
            btnCancela.Enabled = false;
            btnEliminarEscola.Enabled = false;
        }

        private void LimparCampos()
        {
            txtCodEscola.Text = string.Empty;
            txtNomeEscola.Text = string.Empty;
            txtCodCurso.Text = string.Empty;
            txtNomeCurso.Text = string.Empty;
        }
        #endregion

        #region Eventos (verificação/pesquisa/gravação)
        private void btnNovaEscola_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnGravaDados.Enabled = true;
            btnCancela.Enabled = true;
            btnNovaEscola.Enabled = false;
            btnEliminarEscola.Enabled = false;
            txtCodEscola.Focus();
        }

        private void btnGravaDados_Click(object sender, EventArgs e)
        {
            var codEsc = (txtCodEscola.Text ?? string.Empty).Trim();
            var nomeEsc = (txtNomeEscola.Text ?? string.Empty).Trim();
            var codCurso = (txtCodCurso.Text ?? string.Empty).Trim();
            var nomeCurso = (txtNomeCurso.Text ?? string.Empty).Trim();

            if (string.IsNullOrWhiteSpace(codEsc))
            {
                MessageBox.Show("O código da escola é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(nomeEsc))
            {
                MessageBox.Show("O nome da escola é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var escola = EncontrarEscola(codEsc);
            if (escola == null)
            {
                escola = new clsEscola(codEsc, nomeEsc);
                if (!string.IsNullOrWhiteSpace(codCurso) && !string.IsNullOrWhiteSpace(nomeCurso))
                {
                    escola.AdicionarCurso(new clsCurso(codCurso, nomeCurso));
                }
                listaEscolas.Add(escola);
                MessageBox.Show($"Escola {codEsc} adicionada com sucesso.", "Gravação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Atualiza nome opcionalmente
                if (escola.Nome != nomeEsc) escola.Nome = nomeEsc;

                if (!string.IsNullOrWhiteSpace(codCurso) && !string.IsNullOrWhiteSpace(nomeCurso))
                {
                    if (escola.ExisteCurso(codCurso))
                    {
                        MessageBox.Show($"O curso {codCurso} já existe nessa escola.", "Gravação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        escola.AdicionarCurso(new clsCurso(codCurso, nomeCurso));
                        MessageBox.Show($"Curso {codCurso} adicionado à escola {codEsc}.", "Gravação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            AtualizarListViewEscolas();
            ListarCursosDaEscola(escola);

            btnGravaDados.Enabled = false;
            btnCancela.Enabled = false;
            btnNovaEscola.Enabled = true;
            btnEliminarEscola.Enabled = false;
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            LimparCampos();
            ListarCursosDaEscola(null);
            btnGravaDados.Enabled = false;
            btnCancela.Enabled = false;
            btnNovaEscola.Enabled = true;
            btnEliminarEscola.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var codEsc = (txtCodEscola.Text ?? string.Empty).Trim();
            if (string.IsNullOrWhiteSpace(codEsc))
            {
                MessageBox.Show("Introduza o código da escola para pesquisar.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var escola = EncontrarEscola(codEsc);
            if (escola == null)
            {
                MessageBox.Show($"Escola com código {codEsc} não encontrada.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeEscola.Text = string.Empty;
                ListarCursosDaEscola(null);
                return;
            }

            txtNomeEscola.Text = escola.Nome;
            ListarCursosDaEscola(escola);

            // Selecionar na listView
            foreach (ListViewItem item in listViewEscolas.Items)
            {
                if (item.SubItems.Count > 0 && item.SubItems[0].Text == escola.Codigo)
                {
                    item.Selected = true;
                    item.Focused = true;
                    item.EnsureVisible();
                    break;
                }
            }
        }

        private void listViewEscolas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEscolas.SelectedItems.Count == 0)
            {
                btnEliminarEscola.Enabled = false;
                return;
            }
            var selected = listViewEscolas.SelectedItems[0];
            var codigo = selected.SubItems[0].Text;
            var escola = EncontrarEscola(codigo);
            if (escola != null)
            {
                txtCodEscola.Text = escola.Codigo;
                txtNomeEscola.Text = escola.Nome;
                ListarCursosDaEscola(escola);
                btnEliminarEscola.Enabled = true;
            }
            else
            {
                btnEliminarEscola.Enabled = false;
            }
        }

        private void txtCodEscola_Leave(object sender, EventArgs e)
        {
            // Pesquisa automática sem mostrar messagebox se não for encontrada
            var codEsc = (txtCodEscola.Text ?? string.Empty).Trim();
            if (string.IsNullOrWhiteSpace(codEsc)) return;
            var escola = EncontrarEscola(codEsc);
            if (escola != null)
            {
                txtNomeEscola.Text = escola.Nome;
                ListarCursosDaEscola(escola);
            }
            else
            {
                txtNomeEscola.Text = string.Empty;
                ListarCursosDaEscola(null);
            }
        }

        private void btnEliminarEscola_Click(object sender, EventArgs e)
        {
            if (listViewEscolas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione a escola a eliminar na lista.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selected = listViewEscolas.SelectedItems[0];
            var codigo = selected.SubItems[0].Text;
            var escola = EncontrarEscola(codigo);
            if (escola == null)
            {
                MessageBox.Show("Escola não encontrada.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resp = MessageBox.Show($"Tem a certeza que pretende eliminar a escola '{escola.Nome}' ({escola.Codigo})? Esta operação não pode ser desfeita.", "Confirmar eliminação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp != DialogResult.Yes) return;

            listaEscolas.Remove(escola);
            AtualizarListViewEscolas();
            LimparCampos();
            ListarCursosDaEscola(null);
            btnEliminarEscola.Enabled = false;

            MessageBox.Show($"Escola {codigo} eliminada.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
