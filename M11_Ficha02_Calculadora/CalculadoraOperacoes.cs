using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    /// <summary>
    /// Classe estática com operações aritméticas da calculadora
    /// </summary>
    public static class CalculatorOperations
    {
        /// <summary>
        /// Valida se uma string é um número válido
        /// </summary>
        private static double ValidateAndParseOperand(string operand)
        {
            if (string.IsNullOrWhiteSpace(operand))
            {
                throw new CalculadoraSimples.InvalidOperandException("O operando não pode estar vazio.");
            }

            if (!double.TryParse(operand, out double result))
            {
                throw new CalculadoraSimples.InvalidOperandException(
                    $"O operando '{operand}' é inválido. Por favor, insira um número válido.");
            }

            return result;
        }

        /// <summary>
        /// Realiza a adição de dois números
        /// </summary>
        public static double Add(string operand1, string operand2)
        {
            double num1 = ValidateAndParseOperand(operand1);
            double num2 = ValidateAndParseOperand(operand2);
            return num1 + num2;
        }

        /// <summary>
        /// Realiza a subtração de dois números
        /// </summary>
        public static double Subtract(string operand1, string operand2)
        {
            double num1 = ValidateAndParseOperand(operand1);
            double num2 = ValidateAndParseOperand(operand2);
            return num1 - num2;
        }


        /// <summary>
        /// Realiza a multiplicação de dois números
        /// </summary>
        public static double Multiply(string operand1, string operand2)
        {
            double num1 = ValidateAndParseOperand(operand1);
            double num2 = ValidateAndParseOperand(operand2);
            return num1 * num2;
        }

        /// <summary>
        /// Realiza a divisão de dois números
        /// </summary>
        public static double Divide(string operand1, string operand2)
        {
            double num1 = ValidateAndParseOperand(operand1);
            double num2 = ValidateAndParseOperand(operand2);

            if (num2 == 0)
            {
                throw new CalculadoraSimples.DivisionByZeroException(
                    "Erro: Não é possível dividir por zero!");
            }

            return num1 / num2;
        }
    }
}
