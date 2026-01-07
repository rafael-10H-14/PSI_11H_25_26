using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M10_Ex06_Gestão_de_Lutas
{
    public enum CategoriaBoxe
    {
        Invalida,
        PesoLeve,
        PesoMedio,
        PesoPesado
    }
    public class Boxeur : Lutador
    {
        public CategoriaBoxe Categoria { get; private set; }
        public Boxeur(string nome, int idade, double peso)
            : base(nome, idade, peso)
        {
            Categoria = DeterminarCategoria(peso);
        }
        private static CategoriaBoxe DeterminarCategoria(double peso)
        {
            if (peso <= 52.2 || peso > 120.2)
                return CategoriaBoxe.Invalida;
            if (peso < 70.3)
                return CategoriaBoxe.PesoLeve;
            if (peso < 83.9)
                return CategoriaBoxe.PesoMedio;
            return CategoriaBoxe.PesoPesado;
        }
        public override string CategoriaDescricao
        {
            get
            {
                switch (Categoria)
                {
                    case CategoriaBoxe.Invalida:
                        return "Inválida";
                    case CategoriaBoxe.PesoLeve:
                        return "Peso Leve";
                    case CategoriaBoxe.PesoMedio:
                        return "Peso Médio";
                    case CategoriaBoxe.PesoPesado:
                        return "Peso Pesado";
                    default:
                        return "Desconhecida";
                }
            }
        }
        public override void Apresentar()
        {
            base.Apresentar();
        }
    }
}
