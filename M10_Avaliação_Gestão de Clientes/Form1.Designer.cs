using System.Windows.Forms;

namespace GestaoClientes
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // Controles
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtTipo;
        private Button btnAdicionar;
        private Button btnMediaCaracteres;
        private Button btnMaiorPar;
        private ListBox lstClientes;
        private Label lblId;
        private Label lblNome;
        private Label lblTipo;

        /// <summary>
        /// Limpar os recursos em uso.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Código gerado manualmente para inicializar os componentes.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnMediaCaracteres = new System.Windows.Forms.Button();
            this.btnMaiorPar = new System.Windows.Forms.Button();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(100, 17);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(150, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(100, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(350, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(100, 87);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(200, 20);
            this.txtTipo.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(330, 85);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(120, 24);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnMediaCaracteres
            // 
            this.btnMediaCaracteres.Location = new System.Drawing.Point(20, 130);
            this.btnMediaCaracteres.Name = "btnMediaCaracteres";
            this.btnMediaCaracteres.Size = new System.Drawing.Size(180, 30);
            this.btnMediaCaracteres.TabIndex = 7;
            this.btnMediaCaracteres.Text = "Média de caracteres";
            this.btnMediaCaracteres.Click += new System.EventHandler(this.btnMediaCaracteres_Click);
            // 
            // btnMaiorPar
            // 
            this.btnMaiorPar.Location = new System.Drawing.Point(220, 130);
            this.btnMaiorPar.Name = "btnMaiorPar";
            this.btnMaiorPar.Size = new System.Drawing.Size(180, 30);
            this.btnMaiorPar.TabIndex = 8;
            this.btnMaiorPar.Text = "Maior número par";
            this.btnMaiorPar.Click += new System.EventHandler(this.btnMaiorPar_Click);
            // 
            // lstClientes
            // 
            this.lstClientes.Location = new System.Drawing.Point(20, 180);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(560, 173);
            this.lstClientes.TabIndex = 9;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(20, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(56, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID Cliente:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(20, 55);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(73, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome Cliente:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(20, 90);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(66, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo Cliente:";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnMediaCaracteres);
            this.Controls.Add(this.btnMaiorPar);
            this.Controls.Add(this.lstClientes);
            this.Name = "MainForm";
            this.Text = "Gestão de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

