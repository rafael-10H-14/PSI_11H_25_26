using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace M11_F4
{
    internal class Pessoa
    {
        private string Nome;
        private string Morada;
        private string Email;
        public string Telefone;
        public Pessoa (string nome, string morada, string email, string telefone)
        {
            this.Nome = nome;
            this.Morada = morada;
            this.Email = email;
            this.Telefone = telefone;
        }
        public string nome
        {
            get { return nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Nome inválido");
                    nome = value;
            } 
        }
        public string morada
        {
            get { return morada; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    throw new Exception("Morada inválida"); 
                    morada = value;
            }
        }
        public string email
        {
            get { return email; }
            set
            {
                if (!Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    throw new Exception("Email inválido");
                    email = value;
            }
        }
        public string telefone
        {
            get { return telefone; }
            set
            {
                if (!Regex.IsMatch(value, @"^[0-9]{9}$"))
                    throw new Exception("Telefone inválido");
                    telefone = value;
            }
        }
    }
}
