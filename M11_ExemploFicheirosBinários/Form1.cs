using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace M11_ExemploFicheirosBinários
{
    public partial class Form1 : Form
    {
        string caminhoFicheiro = "pessoas.bin";
        List<Pessoa>lista_de_pessoas = new List<Pessoa>();
        public class Pessoa
        {
            private string nome;
            private string morada;
            private DateTime dataNascimento;
            public Pessoa(string nome, string morada, DateTime dataNascimento)
            {
                this.nome = nome;
                this.morada = morada;
                this.dataNascimento = dataNascimento;
            }
            public string Nome { get => nome; set => nome = value;  }
            public string Morada { get => morada; set => morada = value;  }
            public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
            public override string ToString()
            {
                return $"Nome: {Nome}, Morada: {Morada}, Data de Nascimento: {dataNascimento}";
            }
        }
        static void EscreverEmFicheiroBinario(List<Pessoa> pessoas, string caminho)
        {
            try
            {
                using(FileStream fs = new FileStream(caminho, FileMode.OpenOrCreate))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, pessoas);
                }
                MessageBox.Show("Dados escritos com sucesso!", "ESF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ESF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LerDoFicheiroBinario(string caminho)
        {
            try
            {
                if (File.Exists(caminho))
                {
                    using(FileStream fs = new FileStream(caminho, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        lista_de_pessoas = (List<Pessoa>)formatter.Deserialize(fs);
                    }
                    MessageBox.Show("Dados lidos com sucesso!\nForam encontrados " + lista_de_pessoas.Count
                        + " registos", "ESF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ESF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void atualiza_listBox()
        {
            listBox1.Items.Clear();
            foreach(Pessoa p in lista_de_pessoas)
            {
                listBox1.Items.Add(p.ToString());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(caminhoFicheiro))
            {
                LerDoFicheiroBinario(caminhoFicheiro);
                atualiza_listBox();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
