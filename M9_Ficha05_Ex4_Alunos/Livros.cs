using System;

namespace M9_Ficha05_Ex4_Alunos
{
    /// <summary>
    /// Representa um livro na biblioteca virtual.
    /// Ficheiro: Livros.cs
    /// </summary>
    public class Livro
    {
        private int id;
        private string titulo;
        private string autor;
        private string isbn;
        private int anoPublicacao;
        private bool emprestado;
        private Aluno emprestadoA;
        private DateTime dataEmprestimo;

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public Livro()
        {
            id = 0;
            titulo = "";
            autor = "";
            isbn = "";
            anoPublicacao = 0;
            emprestado = false;
            emprestadoA = null;
            dataEmprestimo = DateTime.MinValue;
        }

        /// <summary>
        /// Construtor com atributos principais
        /// </summary>
        public Livro(int novoId, string novoTitulo, string novoAutor, string novoIsbn, int novoAno)
        {
            id = novoId;
            titulo = novoTitulo ?? "";
            autor = novoAutor ?? "";
            isbn = novoIsbn ?? "";
            setAnoPublicacao(novoAno);
            emprestado = false;
            emprestadoA = null;
            dataEmprestimo = DateTime.MinValue;
        }

        /// <summary>
        /// Devolve o id do livro
        /// </summary>
        public int getId()
        {
            return id;
        }

        /// <summary>
        /// Atribui o id do livro
        /// </summary>
        public void setId(int novoId)
        {
            id = novoId;
        }

        /// <summary>
        /// Devolve o título
        /// </summary>
        public string getTitulo()
        {
            return titulo;
        }

        /// <summary>
        /// Atribui o título
        /// </summary>
        public void setTitulo(string novoTitulo)
        {
            titulo = novoTitulo ?? "";
        }

        /// <summary>
        /// Devolve o autor
        /// </summary>
        public string getAutor()
        {
            return autor;
        }

        /// <summary>
        /// Atribui o autor
        /// </summary>
        public void setAutor(string novoAutor)
        {
            autor = novoAutor ?? "";
        }

        /// <summary>
        /// Devolve o ISBN
        /// </summary>
        public string getISBN()
        {
            return isbn;
        }

        /// <summary>
        /// Atribui o ISBN
        /// </summary>
        public void setISBN(string novoIsbn)
        {
            isbn = novoIsbn ?? "";
        }

        /// <summary>
        /// Devolve o ano de publicação
        /// </summary>
        public int getAnoPublicacao()
        {
            return anoPublicacao;
        }

        /// <summary>
        /// Atribui o ano de publicação (validação simples)
        /// </summary>
        public void setAnoPublicacao(int novoAno)
        {
            if (novoAno > 0 && novoAno <= DateTime.Now.Year)
                anoPublicacao = novoAno;
            else
                anoPublicacao = 0;
        }

        /// <summary>
        /// Empresta o livro a um aluno. Retorna true se o empréstimo foi efetuado.
        /// </summary>
        public bool emprestar(Aluno aluno, DateTime? data = null)
        {
            if (aluno == null) return false;
            if (emprestado) return false;

            emprestado = true;
            emprestadoA = aluno;
            dataEmprestimo = data ?? DateTime.Now;
            return true;
        }

        /// <summary>
        /// Devolve o livro. Retorna true se a devolução foi efetuada.
        /// </summary>
        public bool devolver()
        {
            if (!emprestado) return false;

            emprestado = false;
            emprestadoA = null;
            dataEmprestimo = DateTime.MinValue;
            return true;
        }

        /// <summary>
        /// Indica se o livro está emprestado
        /// </summary>
        public bool estaEmprestado()
        {
            return emprestado;
        }

        /// <summary>
        /// Devolve o aluno que tem o livro emprestado (ou null)
        /// </summary>
        public Aluno getAlunoEmprestado()
        {
            return emprestadoA;
        }

        /// <summary>
        /// Devolve a data do empréstimo (DateTime.MinValue se não emprestado)
        /// </summary>
        public DateTime getDataEmprestimo()
        {
            return dataEmprestimo;
        }

        public override string ToString()
        {
            string status = emprestado
                ? $"Emprestado a: {emprestadoA?.getNome() ?? "N/A"} (Nº {emprestadoA?.getNumero().ToString() ?? "N/A"}) em {dataEmprestimo}"
                : "Disponível";
            return $"ID: {id}, Título: {titulo}, Autor: {autor}, ISBN: {isbn}, Ano: {anoPublicacao}, Status: {status}";
        }
    }
}