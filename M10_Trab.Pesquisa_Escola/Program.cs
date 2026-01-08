using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M10_Trab.Pesquisa_Escola
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal da aplicação (.NET Framework 4.7.2).
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
