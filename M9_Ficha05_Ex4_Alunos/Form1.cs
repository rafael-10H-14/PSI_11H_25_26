using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M9_Ficha05_Ex4_Alunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.setNumero(1);
            int numero = aluno.getNumero();
            aluno.setNome("XPTO");
            string nome = aluno.getNome();

            txtNumero.Text = "Número: " + numero;
            txtNome.Text = "Nome: " + nome;
        }
    }
}
