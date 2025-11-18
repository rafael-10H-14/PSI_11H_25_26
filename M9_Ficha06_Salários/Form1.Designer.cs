namespace M9_Ficha06_Salários
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblDescontoSS;
        private System.Windows.Forms.Label lblDescontoIRS;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.TextBox txtDescontoSS;
        private System.Windows.Forms.TextBox txtDescontoIRS;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.Label lblNomeCompletoValor;

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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblApelido = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblDescontoSS = new System.Windows.Forms.Label();
            this.lblDescontoIRS = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.txtDescontoSS = new System.Windows.Forms.TextBox();
            this.txtDescontoIRS = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.lblNomeCompletoValor = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(24, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(24, 50);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(45, 13);
            this.lblApelido.TabIndex = 2;
            this.lblApelido.Text = "Apelido:";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(24, 82);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(69, 13);
            this.lblSalarioBruto.TabIndex = 4;
            this.lblSalarioBruto.Text = "Salário bruto:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(120, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(220, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(120, 47);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(220, 20);
            this.txtApelido.TabIndex = 3;
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Location = new System.Drawing.Point(120, 79);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(120, 20);
            this.txtSalarioBruto.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(120, 110);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(240, 110);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblDescontoSS
            // 
            this.lblDescontoSS.AutoSize = true;
            this.lblDescontoSS.Location = new System.Drawing.Point(24, 160);
            this.lblDescontoSS.Name = "lblDescontoSS";
            this.lblDescontoSS.Size = new System.Drawing.Size(102, 13);
            this.lblDescontoSS.TabIndex = 8;
            this.lblDescontoSS.Text = "Desconto SS (20%):";
            // 
            // lblDescontoIRS
            // 
            this.lblDescontoIRS.AutoSize = true;
            this.lblDescontoIRS.Location = new System.Drawing.Point(24, 190);
            this.lblDescontoIRS.Name = "lblDescontoIRS";
            this.lblDescontoIRS.Size = new System.Drawing.Size(77, 13);
            this.lblDescontoIRS.TabIndex = 10;
            this.lblDescontoIRS.Text = "Desconto IRS:";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(24, 220);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(77, 13);
            this.lblSalarioLiquido.TabIndex = 12;
            this.lblSalarioLiquido.Text = "Salário líquido:";
            // 
            // txtDescontoSS
            // 
            this.txtDescontoSS.Location = new System.Drawing.Point(132, 157);
            this.txtDescontoSS.Name = "txtDescontoSS";
            this.txtDescontoSS.ReadOnly = true;
            this.txtDescontoSS.Size = new System.Drawing.Size(120, 20);
            this.txtDescontoSS.TabIndex = 9;
            // 
            // txtDescontoIRS
            // 
            this.txtDescontoIRS.Location = new System.Drawing.Point(107, 187);
            this.txtDescontoIRS.Name = "txtDescontoIRS";
            this.txtDescontoIRS.ReadOnly = true;
            this.txtDescontoIRS.Size = new System.Drawing.Size(120, 20);
            this.txtDescontoIRS.TabIndex = 11;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Location = new System.Drawing.Point(107, 217);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.ReadOnly = true;
            this.txtSalarioLiquido.Size = new System.Drawing.Size(120, 20);
            this.txtSalarioLiquido.TabIndex = 13;
            // 
            // lblNomeCompletoValor
            // 
            this.lblNomeCompletoValor.AutoSize = true;
            this.lblNomeCompletoValor.Location = new System.Drawing.Point(120, 255);
            this.lblNomeCompletoValor.Name = "lblNomeCompletoValor";
            this.lblNomeCompletoValor.Size = new System.Drawing.Size(0, 13);
            this.lblNomeCompletoValor.TabIndex = 15;
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(24, 255);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(84, 13);
            this.lblNomeCompleto.TabIndex = 14;
            this.lblNomeCompleto.Text = "Nome completo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 300);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblDescontoSS);
            this.Controls.Add(this.txtDescontoSS);
            this.Controls.Add(this.lblDescontoIRS);
            this.Controls.Add(this.txtDescontoIRS);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.lblNomeCompletoValor);
            this.Name = "Form1";
            this.Text = "Processamento de Salários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCompleto;
    }
}

