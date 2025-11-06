using System;

namespace M9_Ex3_Cilindro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cilindro = new Cilindro(3.0, 5.0);

            Console.WriteLine("Raio: {0:F2}", cilindro.Raio);
            Console.WriteLine("Altura: {0:F2}", cilindro.Altura);
            Console.WriteLine("Área da base: {0:F2}", cilindro.AreaBase());
            Console.WriteLine("Área lateral: {0:F2}", cilindro.AreaLateral());
            Console.WriteLine("Área total: {0:F2}", cilindro.AreaTotal());
            Console.WriteLine("Volume: {0:F2}", cilindro.Volume());
            Console.WriteLine("Prima qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
