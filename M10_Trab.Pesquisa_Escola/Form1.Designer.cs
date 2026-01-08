namespace M10_Trab.Pesquisa_Escola
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controles do formulário
        private System.Windows.Forms.TextBox txtCodEscola;
        private System.Windows.Forms.TextBox txtNomeEscola;
        private System.Windows.Forms.TextBox txtCodCurso;
        private System.Windows.Forms.TextBox txtNomeCurso;
        private System.Windows.Forms.Button btnNovaEscola;
        private System.Windows.Forms.Button btnGravaDados;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnEliminarEscola;
        private System.Windows.Forms.ListView listViewEscolas;
        private System.Windows.Forms.ListView listViewCursos;
        private System.Windows.Forms.Label lblCodEscola;
        private System.Windows.Forms.Label lblNomeEscola;
        private System.Windows.Forms.Label lblCodCurso;
        private System.Windows.Forms.Label lblNomeCurso;
        private System.Windows.Forms.Label lblEscolas;
        private System.Windows.Forms.Label lblCursos;

        /// <summary>
        /// Limpar os recursos a usar.
        /// </summary>
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
        /// Método necessário para suporte ao Designer — não editar com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCodEscola = new System.Windows.Forms.Label();
            this.lblNomeEscola = new System.Windows.Forms.Label();
            this.lblCodCurso = new System.Windows.Forms.Label();
            this.lblNomeCurso = new System.Windows.Forms.Label();
            this.lblEscolas = new System.Windows.Forms.Label();
            this.lblCursos = new System.Windows.Forms.Label();

            this.txtCodEscola = new System.Windows.Forms.TextBox();
            this.txtNomeEscola = new System.Windows.Forms.TextBox();
            this.txtCodCurso = new System.Windows.Forms.TextBox();
            this.txtNomeCurso = new System.Windows.Forms.TextBox();

            this.btnNovaEscola = new System.Windows.Forms.Button();
            this.btnGravaDados = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnEliminarEscola = new System.Windows.Forms.Button();

            this.listViewEscolas = new System.Windows.Forms.ListView();
            this.listViewCursos = new System.Windows.Forms.ListView();

            this.SuspendLayout();

            // Labels and TextBoxes
            this.lblCodEscola.AutoSize = true;
            this.lblCodEscola.Location = new System.Drawing.Point(12, 12);
            this.lblCodEscola.Name = "lblCodEscola";
            this.lblCodEscola.Size = new System.Drawing.Size(80, 13);
            this.lblCodEscola.Text = "Código Escola:";

            this.txtCodEscola.Location = new System.Drawing.Point(100, 9);
            this.txtCodEscola.Name = "txtCodEscola";
            this.txtCodEscola.Size = new System.Drawing.Size(140, 20);
            this.txtCodEscola.Leave += new System.EventHandler(this.txtCodEscola_Leave);

            this.lblNomeEscola.AutoSize = true;
            this.lblNomeEscola.Location = new System.Drawing.Point(252, 12);
            this.lblNomeEscola.Name = "lblNomeEscola";
            this.lblNomeEscola.Size = new System.Drawing.Size(72, 13);
            this.lblNomeEscola.Text = "Nome Escola:";

            this.txtNomeEscola.Location = new System.Drawing.Point(330, 9);
            this.txtNomeEscola.Name = "txtNomeEscola";
            this.txtNomeEscola.Size = new System.Drawing.Size(420, 20);

            this.lblCodCurso.AutoSize = true;
            this.lblCodCurso.Location = new System.Drawing.Point(12, 42);
            this.lblCodCurso.Name = "lblCodCurso";
            this.lblCodCurso.Size = new System.Drawing.Size(73, 13);
            this.lblCodCurso.Text = "Código Curso:";

            this.txtCodCurso.Location = new System.Drawing.Point(100, 39);
            this.txtCodCurso.Name = "txtCodCurso";
            this.txtCodCurso.Size = new System.Drawing.Size(140, 20);

            this.lblNomeCurso.AutoSize = true;
            this.lblNomeCurso.Location = new System.Drawing.Point(252, 42);
            this.lblNomeCurso.Name = "lblNomeCurso";
            this.lblNomeCurso.Size = new System.Drawing.Size(67, 13);
            this.lblNomeCurso.Text = "Nome Curso:";

            this.txtNomeCurso.Location = new System.Drawing.Point(330, 39);
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.Size = new System.Drawing.Size(420, 20);

            // Buttons
            this.btnNovaEscola.Location = new System.Drawing.Point(12, 75);
            this.btnNovaEscola.Name = "btnNovaEscola";
            this.btnNovaEscola.Size = new System.Drawing.Size(110, 25);
            this.btnNovaEscola.Text = "Nova Escola";
            this.btnNovaEscola.UseVisualStyleBackColor = true;
            this.btnNovaEscola.Click += new System.EventHandler(this.btnNovaEscola_Click);

            this.btnGravaDados.Location = new System.Drawing.Point(128, 75);
            this.btnGravaDados.Name = "btnGravaDados";
            this.btnGravaDados.Size = new System.Drawing.Size(110, 25);
            this.btnGravaDados.Text = "Grava Dados";
            this.btnGravaDados.UseVisualStyleBackColor = true;
            this.btnGravaDados.Click += new System.EventHandler(this.btnGravaDados_Click);

            this.btnCancela.Location = new System.Drawing.Point(244, 75);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(130, 25);
            this.btnCancela.Text = "Cancela Gravação";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);

            this.btnPesquisar.Location = new System.Drawing.Point(380, 75);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(180, 25);
            this.btnPesquisar.Text = "Pesquisa Dados Escola";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);

            this.btnEliminarEscola.Location = new System.Drawing.Point(566, 75);
            this.btnEliminarEscola.Name = "btnEliminarEscola";
            this.btnEliminarEscola.Size = new System.Drawing.Size(110, 25);
            this.btnEliminarEscola.Text = "Eliminar Escola";
            this.btnEliminarEscola.UseVisualStyleBackColor = true;
            this.btnEliminarEscola.Click += new System.EventHandler(this.btnEliminarEscola_Click);

            // Labels for ListViews
            this.lblEscolas.AutoSize = true;
            this.lblEscolas.Location = new System.Drawing.Point(12, 110);
            this.lblEscolas.Name = "lblEscolas";
            this.lblEscolas.Size = new System.Drawing.Size(44, 13);
            this.lblEscolas.Text = "Escolas:";

            this.lblCursos.AutoSize = true;
            this.lblCursos.Location = new System.Drawing.Point(460, 110);
            this.lblCursos.Name = "lblCursos";
            this.lblCursos.Size = new System.Drawing.Size(84, 13);
            this.lblCursos.Text = "Cursos da Escola:";

            // ListViews
            this.listViewEscolas.Location = new System.Drawing.Point(12, 130);
            this.listViewEscolas.Name = "listViewEscolas";
            this.listViewEscolas.Size = new System.Drawing.Size(440, 360);
            this.listViewEscolas.FullRowSelect = true;
            this.listViewEscolas.GridLines = true;
            this.listViewEscolas.HideSelection = false;
            this.listViewEscolas.SelectedIndexChanged += new System.EventHandler(this.listViewEscolas_SelectedIndexChanged);

            this.listViewCursos.Location = new System.Drawing.Point(460, 130);
            this.listViewCursos.Name = "listViewCursos";
            this.listViewCursos.Size = new System.Drawing.Size(420, 360);
            this.listViewCursos.FullRowSelect = true;
            this.listViewCursos.GridLines = true;

            // MainForm
            this.ClientSize = new System.Drawing.Size(894, 501);
            this.Controls.Add(this.lblCodEscola);
            this.Controls.Add(this.txtCodEscola);
            this.Controls.Add(this.lblNomeEscola);
            this.Controls.Add(this.txtNomeEscola);
            this.Controls.Add(this.lblCodCurso);
            this.Controls.Add(this.txtCodCurso);
            this.Controls.Add(this.lblNomeCurso);
            this.Controls.Add(this.txtNomeCurso);

            this.Controls.Add(this.btnNovaEscola);
            this.Controls.Add(this.btnGravaDados);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnEliminarEscola);

            this.Controls.Add(this.lblEscolas);
            this.Controls.Add(this.listViewEscolas);
            this.Controls.Add(this.lblCursos);
            this.Controls.Add(this.listViewCursos);

            this.Name = "MainForm";
            this.Text = "Gestão de Cursos - POO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

    }
}

