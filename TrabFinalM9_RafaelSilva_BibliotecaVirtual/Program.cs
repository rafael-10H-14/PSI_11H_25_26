using System;
using System.Windows.Forms;

namespace M9_Ficha05_Ex4_Alunos
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada da aplicação WinForms.
        /// Ficheiro: Program.cs
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Cria instância de Biblioteca e carrega dados (se existirem)
            var biblioteca = new Biblioteca();
            try
            {
                biblioteca.Carregar(AppDomain.CurrentDomain.BaseDirectory);
            }
            catch
            {
                // ignorar erros de carregamento inicial
            }

            Application.Run(new Form1(biblioteca));
        }
    }
}
