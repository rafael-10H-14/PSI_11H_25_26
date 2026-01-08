using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Trab.Pesquisa_Escola
{
    public class clsEscola : clsCurso
    {
        public List<clsCurso> Cursos { get; private set; }
        public clsEscola(string codigoEscola, string nomeEscola)
            : base(codigoEscola, nomeEscola)
        {
            Cursos = new List<clsCurso>();
        }
        public bool AdicionarCurso(clsCurso curso)
        {
            if (curso == null) return false;
            if (Cursos.Any(c => c.Codigo == curso.Codigo)) return false;
            Cursos.Add(curso);
            return true;
        }
        public bool ExisteCurso(string codigoCurso)
        {
            if (string.IsNullOrWhiteSpace(codigoCurso)) return false;
            return Cursos.Any(c => c.Codigo == codigoCurso.Trim());
        }
    }
}
