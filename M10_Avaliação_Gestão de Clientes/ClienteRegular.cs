using M10_Avaliação_Gestão_de_Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoClientes
{
    /// ClienteRegular deriva de Cliente e adiciona o atributo tipoCliente.
    /// Implementa polimorfismo ao sobrescrever NumeroCaracteresNome().
    public class ClienteRegular : Cliente
    {
        // Atributo adicional
        private string tipoCliente;

        // Propriedade pública para tipoCliente
        public string TipoCliente
        {
            get { return tipoCliente; }
            set { tipoCliente = value; }
        }

        // Construtor que utiliza o construtor da classe base
        public ClienteRegular(int idCliente, string nome, string tipoCliente)
            : base(idCliente, nome)
        {
            this.tipoCliente = tipoCliente;
        }

        /// Override do método que calcula o número de caracteres do nome.
        /// Exemplo de comportamento: conta caracteres excluindo espaços.
        /// Demonstra polimorfismo.
        public override int NumeroCaracteresNome()
        {
            var nome = this.Nome ?? string.Empty;
            // Conta caracteres sem espaços
            int count = 0;
            foreach (char c in nome)
            {
                if (!char.IsWhiteSpace(c)) count++;
            }
            return count;
        }
    }
}