using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Trab.Pesquisa_Escola
{
    public class clsCurso
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public clsCurso(string codigo, string nome)
        {
            Codigo = (codigo ?? string.Empty).Trim();
            Nome = (nome ?? string.Empty).Trim();
        }
        public override string ToString()
        {
            return $"{Codigo} - {Nome}";
        }
    }
}
