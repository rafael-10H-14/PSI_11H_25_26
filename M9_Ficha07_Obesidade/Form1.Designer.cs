using System.Windows.Forms;

namespace M9_Ficha07_Obesidade
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Código gerado pelo Windows Form Designer
        private void InitializeComponent()
        {
            this.groupBoxGenero = new System.Windows.Forms.GroupBox();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.groupBoxUtente = new System.Windows.Forms.GroupBox();
            this.labelIdade = new System.Windows.Forms.Label();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.labelPeso = new System.Windows.Forms.Label();
            this.numericUpDownPeso = new System.Windows.Forms.NumericUpDown();
            this.labelAltura = new System.Windows.Forms.Label();
            this.numericUpDownAltura = new System.Windows.Forms.NumericUpDown();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.buttonRepor = new System.Windows.Forms.Button();
            this.groupBoxInformacoes = new System.Windows.Forms.GroupBox();
            this.labelIMC = new System.Windows.Forms.Label();
            this.labelClassificacao = new System.Windows.Forms.Label();
            this.labelRisco = new System.Windows.Forms.Label();
            this.groupBoxGenero.SuspendLayout();
            this.groupBoxUtente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAltura)).BeginInit();
            this.groupBoxInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGenero
            // 
            this.groupBoxGenero.Controls.Add(this.radioButtonFeminino);
            this.groupBoxGenero.Controls.Add(this.radioButtonMasculino);
            this.groupBoxGenero.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGenero.Name = "groupBoxGenero";
            this.groupBoxGenero.Size = new System.Drawing.Size(200, 80);
            this.groupBoxGenero.TabIndex = 0;
            this.groupBoxGenero.TabStop = false;
            this.groupBoxGenero.Text = "Género";
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Location = new System.Drawing.Point(16, 47);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFeminino.TabIndex = 2;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Checked = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(16, 24);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 1;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBoxUtente
            // 
            this.groupBoxUtente.Controls.Add(this.labelIdade);
            this.groupBoxUtente.Controls.Add(this.textBoxIdade);
            this.groupBoxUtente.Controls.Add(this.labelPeso);
            this.groupBoxUtente.Controls.Add(this.numericUpDownPeso);
            this.groupBoxUtente.Controls.Add(this.labelAltura);
            this.groupBoxUtente.Controls.Add(this.numericUpDownAltura);
            this.groupBoxUtente.Location = new System.Drawing.Point(12, 100);
            this.groupBoxUtente.Name = "groupBoxUtente";
            this.groupBoxUtente.Size = new System.Drawing.Size(320, 130);
            this.groupBoxUtente.TabIndex = 3;
            this.groupBoxUtente.TabStop = false;
            this.groupBoxUtente.Text = "Dados do Utente";
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Location = new System.Drawing.Point(16, 28);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(37, 13);
            this.labelIdade.TabIndex = 0;
            this.labelIdade.Text = "Idade:";
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(90, 25);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(80, 20);
            this.textBoxIdade.TabIndex = 1;
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(16, 62);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(34, 13);
            this.labelPeso.TabIndex = 2;
            this.labelPeso.Text = "Peso:";
            // 
            // numericUpDownPeso
            // 
            this.numericUpDownPeso.Location = new System.Drawing.Point(90, 60);
            this.numericUpDownPeso.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDownPeso.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownPeso.Name = "numericUpDownPeso";
            this.numericUpDownPeso.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownPeso.TabIndex = 3;
            this.numericUpDownPeso.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownPeso.ValueChanged += new System.EventHandler(this.numericUpDownPeso_ValueChanged);
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(16, 95);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(37, 13);
            this.labelAltura.TabIndex = 4;
            this.labelAltura.Text = "Altura:";
            // 
            // numericUpDownAltura
            // 
            this.numericUpDownAltura.DecimalPlaces = 2;
            this.numericUpDownAltura.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownAltura.Location = new System.Drawing.Point(90, 92);
            this.numericUpDownAltura.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            131072});
            this.numericUpDownAltura.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAltura.Name = "numericUpDownAltura";
            this.numericUpDownAltura.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownAltura.TabIndex = 5;
            this.numericUpDownAltura.Value = new decimal(new int[] {
            111,
            0,
            0,
            131072});
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(360, 120);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(140, 35);
            this.buttonCalcular.TabIndex = 6;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // buttonRepor
            // 
            this.buttonRepor.Location = new System.Drawing.Point(360, 165);
            this.buttonRepor.Name = "buttonRepor";
            this.buttonRepor.Size = new System.Drawing.Size(140, 35);
            this.buttonRepor.TabIndex = 7;
            this.buttonRepor.Text = "Repor";
            this.buttonRepor.UseVisualStyleBackColor = true;
            this.buttonRepor.Click += new System.EventHandler(this.buttonRepor_Click);
            // 
            // groupBoxInformacoes
            // 
            this.groupBoxInformacoes.Controls.Add(this.labelIMC);
            this.groupBoxInformacoes.Controls.Add(this.labelClassificacao);
            this.groupBoxInformacoes.Controls.Add(this.labelRisco);
            this.groupBoxInformacoes.Location = new System.Drawing.Point(12, 240);
            this.groupBoxInformacoes.Name = "groupBoxInformacoes";
            this.groupBoxInformacoes.Size = new System.Drawing.Size(488, 78);
            this.groupBoxInformacoes.TabIndex = 8;
            this.groupBoxInformacoes.TabStop = false;
            this.groupBoxInformacoes.Text = "Informações";
            // 
            // labelIMC
            // 
            this.labelIMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelIMC.Location = new System.Drawing.Point(16, 24);
            this.labelIMC.Name = "labelIMC";
            this.labelIMC.Size = new System.Drawing.Size(150, 20);
            this.labelIMC.TabIndex = 0;
            this.labelIMC.Click += new System.EventHandler(this.labelIMC_Click);
            // 
            // labelClassificacao
            // 
            this.labelClassificacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelClassificacao.Location = new System.Drawing.Point(182, 24);
            this.labelClassificacao.Name = "labelClassificacao";
            this.labelClassificacao.Size = new System.Drawing.Size(150, 20);
            this.labelClassificacao.TabIndex = 1;
            // 
            // labelRisco
            // 
            this.labelRisco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRisco.Location = new System.Drawing.Point(348, 24);
            this.labelRisco.Name = "labelRisco";
            this.labelRisco.Size = new System.Drawing.Size(120, 20);
            this.labelRisco.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 330);
            this.Controls.Add(this.groupBoxGenero);
            this.Controls.Add(this.groupBoxUtente);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.buttonRepor);
            this.Controls.Add(this.groupBoxInformacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Índice de Massa Corporal";
            this.groupBoxGenero.ResumeLayout(false);
            this.groupBoxGenero.PerformLayout();
            this.groupBoxUtente.ResumeLayout(false);
            this.groupBoxUtente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAltura)).EndInit();
            this.groupBoxInformacoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.GroupBox groupBoxGenero;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.GroupBox groupBoxUtente;
        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.NumericUpDown numericUpDownPeso;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.NumericUpDown numericUpDownAltura;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button buttonRepor;
        private System.Windows.Forms.GroupBox groupBoxInformacoes;
        private System.Windows.Forms.Label labelIMC;
        private System.Windows.Forms.Label labelClassificacao;
        private System.Windows.Forms.Label labelRisco;
    }
}

