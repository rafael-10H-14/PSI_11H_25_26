using System;

namespace M9_Ficha05_Ex4_Alunos
{
    public class Aluno
    {
        private int numero;
        private string nome;

        /// <summary>
        /// Construtor Padrão (não torna qualquer valor)
        /// </summary>
        public Aluno()
        {
            numero = 0;
            nome = "";
        }

        /// <summary>
        /// Construtor com atributos
        /// </summary>
        /// <param name="novoNum">Número a atribuir</param>
        /// <param name="novoNome">Nome a atribuir</param>
        public Aluno(int novoNum, string novoNome)
        {
            numero = novoNum;
            nome = novoNome;
        }

        /// <summary>
        /// Devolve o número
        /// </summary>
        /// <returns>O número do aluno</returns>
        public int getNumero()
        {
            return numero;
        }

        /// <summary>
        /// Atribui o número
        /// </summary>
        /// <param name="novoNum">Número a atribuir</param>
        public void setNumero(int novoNum)
        {
            numero = novoNum;
        }

        /// <summary>
        /// Devolve o nome
        /// </summary>
        /// <returns>O nome do aluno</returns>
        public string getNome()
        {
            return nome;
        }

        /// <summary>
        /// Atribui o nome
        /// </summary>
        /// <param name="novoNome">Nome a atribuir</param>
        public void setNome(string novoNome)
        {
            nome = novoNome;
        }

        public override string ToString()
        {
            return $"Número: {numero}, Nome: {nome}";
        }
    }
}
