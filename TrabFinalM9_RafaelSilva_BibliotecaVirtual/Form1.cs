using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace M9_Ficha05_Ex4_Alunos
{
    public partial class Form1 : Form
    {
        // Correct type for the field and keep it private readonly
        private readonly Biblioteca biblioteca;

        public Form1(Biblioteca biblioteca)
        {
            this.biblioteca = biblioteca ?? throw new ArgumentNullException(nameof(biblioteca));
            InitializeComponent();

            // re-wire designer stub handlers to real methods
            btnAddLivro.Click -= BtnAddLivro_Click;
            btnAddLivro.Click += BtnAddLivro_Click;

            btnAddAluno.Click -= BtnAddAluno_Click;
            btnAddAluno.Click += BtnAddAluno_Click;

            btnEmprestar.Click -= BtnEmprestar_Click;
            btnEmprestar.Click += BtnEmprestar_Click;

            btnDevolver.Click -= BtnDevolver_Click;
            btnDevolver.Click += BtnDevolver_Click;

            btnSalvar.Click -= BtnSalvar_Click;
            btnSalvar.Click += BtnSalvar_Click;

            btnCarregar.Click -= BtnCarregar_Click;
            btnCarregar.Click += BtnCarregar_Click;

            lbLivros.DoubleClick -= LbLivros_DoubleClick;
            lbLivros.DoubleClick += LbLivros_DoubleClick;

            RefreshLists();
        }

        private void BtnAddLivro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTitulo.Text))
            {
                MessageBox.Show("Forneça um título.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ano = 0;
            int.TryParse(tbAno.Text, out ano);

            int novoId = GerarIdLivro();
            var l = new Livro(novoId, tbTitulo.Text.Trim(), tbAutor.Text.Trim(), tbISBN.Text.Trim(), ano);
            biblioteca.AddLivro(l);
            RefreshLists();
            LimparCamposLivro();
            lblStatus.Text = $"Livro '{l.getTitulo()}' adicionado (ID {l.getId()}).";
        }

        private void BtnAddAluno_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbAlunoNumero.Text, out int numero))
            {
                MessageBox.Show("Número inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(tbAlunoNome.Text))
            {
                MessageBox.Show("Forneça um nome.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var a = new Aluno(numero, tbAlunoNome.Text.Trim());
                biblioteca.AddAluno(a);
                RefreshLists();
                tbAlunoNumero.Text = "";
                tbAlunoNome.Text = "";
                lblStatus.Text = $"Aluno '{a.getNome()}' adicionado.";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEmprestar_Click(object sender, EventArgs e)
        {
            var livro = SelectedLivro();
            var aluno = SelectedAluno();
            if (livro == null || aluno == null)
            {
                MessageBox.Show("Selecione um livro e um aluno.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (livro.estaEmprestado())
            {
                MessageBox.Show("Livro já está emprestado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool ok = biblioteca.Emprestar(livro.getId(), aluno.getNumero());
            if (ok)
            {
                RefreshLists();
                lblStatus.Text = $"Livro '{livro.getTitulo()}' emprestado a {aluno.getNome()}.";
            }
            else
            {
                MessageBox.Show("Não foi possível efetuar o empréstimo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDevolver_Click(object sender, EventArgs e)
        {
            var livro = SelectedLivro();
            if (livro == null)
            {
                MessageBox.Show("Selecione um livro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!livro.estaEmprestado())
            {
                MessageBox.Show("Livro não está emprestado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool ok = biblioteca.Devolver(livro.getId());
            if (ok)
            {
                RefreshLists();
                lblStatus.Text = $"Livro '{livro.getTitulo()}' devolvido.";
            }
            else
            {
                MessageBox.Show("Não foi possível devolver o livro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                biblioteca.Salvar(AppDomain.CurrentDomain.BaseDirectory);
                lblStatus.Text = "Dados salvos.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                biblioteca.Carregar(AppDomain.CurrentDomain.BaseDirectory);
                RefreshLists();
                lblStatus.Text = "Dados carregados.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LbLivros_DoubleClick(object sender, EventArgs e)
        {
            var l = SelectedLivro();
            if (l == null) return;
            MessageBox.Show(l.ToString(), "Detalhes do Livro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Livro SelectedLivro()
        {
            return lbLivros.SelectedItem as Livro;
        }

        private Aluno SelectedAluno()
        {
            return lbAlunos.SelectedItem as Aluno;
        }

        private void RefreshLists()
        {
            lbLivros.Items.Clear();
            foreach (var l in biblioteca.ListarLivros())
            {
                lbLivros.Items.Add(l);
            }

            lbAlunos.Items.Clear();
            foreach (var a in biblioteca.ListarAlunos())
            {
                lbAlunos.Items.Add(a);
            }

            // usa ToString() das classes
            lbLivros.DisplayMember = null;
            lbAlunos.DisplayMember = null;
        }

        private int GerarIdLivro()
        {
            var todos = biblioteca.ListarLivros();
            if (!todos.Any()) return 1;
            return todos.Max(x => x.getId()) + 1;
        }

        private void LimparCamposLivro()
        {
            tbTitulo.Text = "";
            tbAutor.Text = "";
            tbISBN.Text = "";
            tbAno.Text = "";
        }

        private void lbLivros_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAlunos.Items.Clear();
            foreach (var a in biblioteca.ListarAlunos())
            {
                lbAlunos.Items.Add(a);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}