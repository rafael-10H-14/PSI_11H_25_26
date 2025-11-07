using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M9_Ficha05_Ex5_Carros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carro carro1 = new Carro("Toyota", "Corolla", "Prata", 1800);
            carro1.Acelerar(50);
            MessageBox.Show(carro1.ToString(), "Estado do Carro 1");
            carro1.Frear(20);
            MessageBox.Show(carro1.ToString(), "Estado do Carro 1 após travar");
        }
    }
}
