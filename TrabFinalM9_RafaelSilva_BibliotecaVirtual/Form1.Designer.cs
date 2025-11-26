namespace M9_Ficha05_Ex4_Alunos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controls referenced from Form1.cs
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.TextBox tbAlunoNumero;
        private System.Windows.Forms.TextBox tbAlunoNome;
        private System.Windows.Forms.Button btnAddLivro;
        private System.Windows.Forms.Button btnAddAluno;
        private System.Windows.Forms.Button btnEmprestar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.ListBox lbLivros;
        private System.Windows.Forms.ListBox lbAlunos;
        private System.Windows.Forms.Label lblStatus;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.tbAlunoNumero = new System.Windows.Forms.TextBox();
            this.tbAlunoNome = new System.Windows.Forms.TextBox();
            this.btnAddLivro = new System.Windows.Forms.Button();
            this.btnAddAluno = new System.Windows.Forms.Button();
            this.btnEmprestar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.lbLivros = new System.Windows.Forms.ListBox();
            this.lbAlunos = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.lblNumeroAluno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(80, 12);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(200, 20);
            this.tbTitulo.TabIndex = 0;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(80, 41);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(200, 20);
            this.tbAutor.TabIndex = 1;
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(129, 67);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(151, 20);
            this.tbISBN.TabIndex = 2;
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(80, 94);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(200, 20);
            this.tbAno.TabIndex = 3;
            // 
            // tbAlunoNumero
            // 
            this.tbAlunoNumero.Location = new System.Drawing.Point(524, 67);
            this.tbAlunoNumero.Name = "tbAlunoNumero";
            this.tbAlunoNumero.Size = new System.Drawing.Size(163, 20);
            this.tbAlunoNumero.TabIndex = 5;
            // 
            // tbAlunoNome
            // 
            this.tbAlunoNome.Location = new System.Drawing.Point(540, 41);
            this.tbAlunoNome.Name = "tbAlunoNome";
            this.tbAlunoNome.Size = new System.Drawing.Size(147, 20);
            this.tbAlunoNome.TabIndex = 6;
            // 
            // btnAddLivro

            // 
            this.btnAddLivro.Location = new System.Drawing.Point(29, 140);
            this.btnAddLivro.Name = "btnAddLivro";
            this.btnAddLivro.Size = new System.Drawing.Size(251, 23);
            this.btnAddLivro.TabIndex = 4;
            this.btnAddLivro.Text = "Adicionar Livro";
            this.btnAddLivro.UseVisualStyleBackColor = true;
            // 
            // btnAddAluno
            // 
            this.btnAddAluno.Location = new System.Drawing.Point(502, 140);
            this.btnAddAluno.Name = "btnAddAluno";
            this.btnAddAluno.Size = new System.Drawing.Size(185, 23);
            this.btnAddAluno.TabIndex = 7;
            this.btnAddAluno.Text = "Adicionar Aluno";
            this.btnAddAluno.UseVisualStyleBackColor = true;
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.Location = new System.Drawing.Point(345, 63);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(100, 23);
            this.btnEmprestar.TabIndex = 10;
            this.btnEmprestar.Text = "Emprestar";
            this.btnEmprestar.UseVisualStyleBackColor = true;
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(345, 92);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(100, 23);
            this.btnDevolver.TabIndex = 11;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(345, 150);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(345, 121);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(100, 23);
            this.btnCarregar.TabIndex = 13;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            // 
            // lbLivros
            // 
            this.lbLivros.Location = new System.Drawing.Point(12, 179);
            this.lbLivros.Name = "lbLivros";
            this.lbLivros.Size = new System.Drawing.Size(395, 121);
            this.lbLivros.TabIndex = 8;
            this.lbLivros.SelectedIndexChanged += new System.EventHandler(this.lbLivros_SelectedIndexChanged);
            // 
            // lbAlunos
            // 
            this.lbAlunos.Location = new System.Drawing.Point(502, 195);
            this.lbAlunos.Name = "lbAlunos";
            this.lbAlunos.Size = new System.Drawing.Size(185, 186);
            this.lbAlunos.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 350);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 14;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(26, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Título";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(26, 43);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 16;
            this.lblAutor.Text = "Autor";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(26, 70);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(97, 13);
            this.lblISBN.TabIndex = 17;
            this.lblISBN.Text = "Nº de identificação";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(26, 96);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(26, 13);
            this.lblAno.TabIndex = 18;
            this.lblAno.Text = "Ano";
            this.lblAno.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Location = new System.Drawing.Point(499, 44);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(35, 13);
            this.lblNomeAluno.TabIndex = 19;
            this.lblNomeAluno.Text = "Nome";
            // 
            // lblNumeroAluno
            // 
            this.lblNumeroAluno.AutoSize = true;
            this.lblNumeroAluno.Location = new System.Drawing.Point(499, 70);
            this.lblNumeroAluno.Name = "lblNumeroAluno";
            this.lblNumeroAluno.Size = new System.Drawing.Size(19, 13);
            this.lblNumeroAluno.TabIndex = 20;
            this.lblNumeroAluno.Text = "Nº";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(720, 408);
            this.Controls.Add(this.lblNumeroAluno);
            this.Controls.Add(this.lblNomeAluno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnEmprestar);
            this.Controls.Add(this.lbAlunos);
            this.Controls.Add(this.lbLivros);
            this.Controls.Add(this.btnAddAluno);
            this.Controls.Add(this.tbAlunoNome);
            this.Controls.Add(this.tbAlunoNumero);
            this.Controls.Add(this.btnAddLivro);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbTitulo);
            this.Name = "Form1";
            this.Text = "Biblioteca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.Label lblNumeroAluno;
    }
}

