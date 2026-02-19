using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Caminho do ficheiro
            string CaminhoFicheiro = @"\C:\\Users\\a7660\\OneDrive - Escola Secundária Adolfo Portela\\Ambiente de Trabalho\\GitHub\\PSI_11H_25_26\\Stream\\bin\\Debug\\FicheiroStream.txt\";

            //Escreve dados em um ficheiro
            using (FileStream stream = new FileStream(CaminhoFicheiro , FileMode.CreateNew)
            {
                byte[] dados = System.Text.Encoding.UTF8.GetBytes("Olá Mundo");
                stream.Write(dados, 0, dados.Length);
            }

            //Ler dados de um ficheiro
            using (FileStream stream = new FileStream(CaminhoFicheiro, FileMode.Open))
            {
                byte[] buffer = new byte[1024];
                int bytesLidos = stream.Read(buffer, 0, buffer.Length);
                string texto = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesLidos);
                Console.WriteLine("Conteúdo do Ficheiro: " + texto);
            }
        }
    }
}
