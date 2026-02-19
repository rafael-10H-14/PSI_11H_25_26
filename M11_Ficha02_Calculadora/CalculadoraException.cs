using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimples
{
    /// <summary>
    /// Exceção personalizada para erros da calculadora
    /// </summary>
    public class CalculatorException : Exception
    {
        public CalculatorException(string message) : base(message)
        {
        }

        public CalculatorException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    /// <summary>
    /// Exceção para operandos inválidos
    /// </summary>
    public class InvalidOperandException : CalculatorException
    {
        public InvalidOperandException(string message) : base(message)
        {
        }
    }

    /// <summary>
    /// Exceção para divisão por zero
    /// </summary>
    public class DivisionByZeroException : CalculatorException
    {
        public DivisionByZeroException(string message) : base(message)
        {
        }
    }
}
