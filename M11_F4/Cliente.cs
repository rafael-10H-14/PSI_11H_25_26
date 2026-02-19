using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11_F4
{
    internal class Cliente: Pessoa
    {
        private int numeroCliente;
        private string nif;
        private double taxaDesconto;
        public Cliente(string nome, string morada, string email, string telefone,
            int numeroCliente, string nif, double taxaDesconto) :
            base(nome, morada, email, telefone)
        {
            this.numeroCliente = numeroCliente;
            this.nif = nif;
            this.taxaDesconto = taxaDesconto;
        }
        public int NumeroCliente
        {
            get { return numeroCliente; }
            set
            {
                if (value <= 0)
                    throw new Exception("Número inválido");
                numeroCliente = value;
            }
        }
        public string NIF
        {
            get { return nif; } 
            set
            {
                if (value.Length != 9)
                    throw new Exception("NIF inválido");
                    nif = value;
            }
        }
        public double TaxaDesconto
        {
            get { return taxaDesconto; }
            set
            {
                if (value < 0 || value > 100)
                    throw new Exception("Taxa inválida");
                    taxaDesconto = value;
            }
        }
    }
}
