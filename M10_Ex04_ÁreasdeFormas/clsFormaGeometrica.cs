using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Ex04_ÁreasdeFormas
{
    /// <summary>
    /// Classe base para todas as formas geométricas
    /// Define propriedades e métodos comuns
    /// </summary>
    public abstract class clsFormaGeometrica
    {
        // Propriedades
        protected string nome;
        protected double area;
        protected double perimetro;

        /// <summary>
        /// Construtor da classe base
        /// </summary>
        /// <param name="nome">Nome da forma geométrica</param>
        public clsFormaGeometrica(string nome)
        {
            this.nome = nome;
            this.area = 0;
            this.perimetro = 0;
        }

        // Propriedades públicas
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Area
        {
            get { return area; }
            protected set { area = value; }
        }

        public double Perimetro
        {
            get { return perimetro; }
            protected set { perimetro = value; }
        }

        /// <summary>
        /// Método abstrato para calcular a área
        /// Deve ser implementado pelas classes derivadas
        /// </summary>
        public abstract void CalcularArea();

        /// <summary>
        /// Método abstrato para calcular o perímetro
        /// Deve ser implementado pelas classes derivadas
        /// </summary>
        public abstract void CalcularPerimetro();

        /// <summary>
        /// Método para obter informações da forma
        /// </summary>
        /// <returns>String com as informações da forma</returns>
        public virtual string ObterInformacoes()
        {
            return string.Format("Forma: {0}\nÁrea: {1:F2}\nPerímetro: {2:F2}",
                nome, area, perimetro);
        }
    }
}