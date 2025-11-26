using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace M9_Ficha05_Ex4_Alunos
{
    /// <summary>
    /// Form construído programaticamente para gerir a biblioteca.
    /// Ficheiro: MainForm.cs
    /// </summary>
    public class MainForm : Form
    {
        private readonly Biblioteca biblioteca;

        private ListBox lbLivros;
        private ListBox lbAlunos;
        private Button btnAddLivro;
        private Button btnAddAluno;
        private Button btnEmprestar;
        private Button btnDevolver;
        private Button btnSalvar;
        private Button btnCarregar;
        private TextBox tbTitulo, tbAutor, tbISBN, tbAno;
        private TextBox tbAlunoNumero, tbAlunoNome;
        private Label lblStatus;

        public MainForm(Biblioteca biblioteca)
        {
            this.biblioteca = biblioteca ?? throw new ArgumentNullException(nameof(biblioteca));
            InitializeComponent();
            RefreshLists();
        }

        private void InitializeComponent()
        {
            Text = "Biblioteca Virtual";
            Size = new Size(900, 520);
            StartPosition = FormStartPosition.CenterScreen;

            lbLivros = new ListBox { Location = new Point(10, 10), Size = new Size(540, 200) };
            lbAlunos = new ListBox { Location = new Point(10, 220), Size = new Size(540, 200) };

            // Campos de livro
            var lblLivro = new Label { Text = "Adicionar Livro", Location = new Point(560, 10), AutoSize = true };
            tbTitulo = new TextBox { Location = new Point(560, 35), Width = 300, PlaceholderText = "Título" };
            tbAutor = new TextBox { Location = new Point(560, 65), Width = 300, PlaceholderText = "Autor" };
            tbISBN = new TextBox { Location = new Point(560, 95), Width = 300, PlaceholderText = "ISBN" };
            tbAno = new TextBox { Location = new Point(560, 125), Width = 120, PlaceholderText = "Ano" };
            btnAddLivro = new Button { Text = "Adicionar Livro", Location = new Point(560, 155), Width = 140 };
            btnAddLivro.Click += BtnAddLivro_Click;

            // Campos de aluno
            var lblAluno = new Label { Text = "Adicionar Aluno", Location = new Point(560, 200), AutoSize = true };
            tbAlunoNumero = new TextBox { Location = new Point(560, 225), Width = 120, PlaceholderText = "Número (int)" };
            tbAlunoNome = new TextBox { Location = new Point(560, 255), Width = 300, PlaceholderText = "Nome" };
            btnAddAluno = new Button { Text = "Adicionar Aluno", Location = new Point(560, 285), Width = 140 };
            btnAddAluno.Click += BtnAddAluno_Click;

            // Empréstimo / Devolução
            btnEmprestar = new Button { Text = "Emprestar (selecionar livro + aluno)", Location = new Point(10, 430), Width = 260 };
            btnEmprestar.Click += BtnEmprestar_Click;
            btnDevolver = new Button { Text = "Devolver (selecionar livro)", Location = new Point(280, 430), Width = 200 };
            btnDevolver.Click += BtnDevolver_Click;

            btnSalvar = new Button { Text = "Salvar dados", Location = new Point(560, 330), Width = 140 };
            btnSalvar.Click += BtnSalvar_Click;
            btnCarregar = new Button { Text = "Carregar dados", Location = new Point(710, 330), Width = 140 };
            btnCarregar.Click += BtnCarregar_Click;

            lblStatus = new Label { Text = "Pronto", Location = new Point(10, 470), AutoSize = true };

            Controls.AddRange(new Control[] {
                lbLivros, lbAlunos, lblLivro, tbTitulo, tbAutor, tbISBN, tbAno, btnAddLivro,
                lblAluno, tbAlunoNumero, tbAlunoNome, btnAddAluno, btnEmprestar, btnDevolver, btnSalvar, btnCarregar, lblStatus
            });

            lbLivros.DoubleClick += (s,e) => { MostrarDetalhesLivroSelecionado(); };
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

            // Define como string o método ToString já definido em Livro e Aluno
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

        private void MostrarDetalhesLivroSelecionado()
        {
            var l = SelectedLivro();
            if (l == null) return;
            MessageBox.Show(l.ToString(), "Detalhes do Livro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}