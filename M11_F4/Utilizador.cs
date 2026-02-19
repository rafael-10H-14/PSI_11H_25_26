using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11_F4
{
    internal class Utilizador: Pessoa
    {
        private string UserName {  get; set; }
        private string Password { get; set; }


        public Utilizador (string Nome, string Morada, string Email, string Telefone,
            string Username, string Pass_word):base(nome, morada, email, telefone)
        {
            UserName = Username;
            Password = Pass_word;
        }
    }
}
