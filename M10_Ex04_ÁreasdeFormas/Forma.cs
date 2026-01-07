using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Ex04_ÁreasdeFormas
{
    public class Forma
    {
        public virtual double CalcularArea()
        {
            return 0.0;
        }

        public virtual void ExibirArea()
        {
            Console.WriteLine($"Área: {CalcularArea():F2}");
        }
    }
}
