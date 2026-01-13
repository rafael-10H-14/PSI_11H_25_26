using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoClientes
{

    /// Classe abstrata Cliente com encapsulamento e métodos requisitados.
    public abstract class Cliente
    {
        // Atributos privados
        private int idCliente;
        private string nome;

        // Propriedades públicas (encapsulamento)
        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        // Construtor que recebe os dois atributos
        protected Cliente(int idCliente, string nome)
        {
            this.idCliente = idCliente;
            this.nome = nome;
        }

        /// Método virtual que devolve o número de caracteres do nome.
        /// Pode ser sobrescrito pelas classes derivadas (polimorfismo).
        public virtual int NumeroCaracteresNome()
        {
            return string.IsNullOrEmpty(nome) ? 0 : nome.Length;
        }

        /// Indica se o idCliente é par ou ímpar.
        /// Retorna "Par" ou "Ímpar".
        public string ParOuImpar()
        {
            return (idCliente % 2 == 0) ? "Par" : "Ímpar";
        }
    }
}
