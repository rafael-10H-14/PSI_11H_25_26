namespace M9_Ficha06_Salários
{
    public class Pessoa
    {
        public string nome;
        public string apelido;
        public double salarioBruto;

        // Construtor padrão (sem argumentos)
        public Pessoa()
        {
            nome = string.Empty;
            apelido = string.Empty;
            salarioBruto = 0.0;
        }

        // Construtor que recebe todos os atributos
        public Pessoa(string nome, string apelido, double salarioBruto)
        {
            this.nome = nome ?? string.Empty;
            this.apelido = apelido ?? string.Empty;
            this.salarioBruto = salarioBruto;
        }

        // Devolve o nome completo
        public string NomeCompleto()
        {
            return $"{nome} {apelido}".Trim();
        }
    }
}