using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Ex06_Gestão_de_Lutas
{
    class Program
    {
        static void Main(string[] args)
        {
            var lutador = new Lutador("Rui Mendes", 27, 78.5);
            var boxeur = new Boxeur("Carlos Silva", 24, 69.8);
            lutador.RegistrarVitoria();
            lutador.RegistrarVitoria();
            lutador.RegistrarDerrota();
            lutador.RegistrarEmpate();
            boxeur.RegistrarVitoria();
            boxeur.RegistrarDerrota();
            List<Lutador> competidores = new List<Lutador> { lutador, boxeur };
            Console.WriteLine("=== Dados dos competidores ===\n");
            foreach (var c in competidores)
            {
                c.Apresentar();
            }
            Console.WriteLine("Pressione uma tecla para sair...");
            Console.ReadKey();
        }
    }
}
