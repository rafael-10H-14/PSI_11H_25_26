using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    /// Exceção base para erros da calculadora
    public class CalculadoraException : Exception
    {
        public CalculadoraException(string mensagem) : base(mensagem) { }
    }
    /// Exceção para operandos inválidos (não numéricos)
    public class OperandoInvalidoException : CalculadoraException
    {
        public OperandoInvalidoException()
            : base("Erro: Os operandos devem ser valores numéricos válidos!") { }
    }
    /// Exceção para tentativa de divisão por zero
    public class DivisaoPorZeroException : CalculadoraException
    {
        public DivisaoPorZeroException()
            : base("Erro: Não é permitido divisão por zero!") { }
    }
    /// Exceção para operação inválida
    public class OperacaoInvalidaException : CalculadoraException
    {
        public OperacaoInvalidaException(string operacao)
            : base($"Erro: Operação '{operacao}' não é válida!") { }
    }
}