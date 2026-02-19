using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    /// Classe estática que contém todos os métodos de operações aritméticas
    public static class CalculadoraOperacoes
    {
        /// Realiza a adição de dois números
        public static decimal Adicionar(string operando1, string operando2)
        {
            ValidarOperandos(operando1, operando2);

            decimal num1 = decimal.Parse(operando1);
            decimal num2 = decimal.Parse(operando2);

            return num1 + num2;
        }
        /// Realiza a subtração de dois números
        public static decimal Subtrair(string operando1, string operando2)
        {
            ValidarOperandos(operando1, operando2);

            decimal num1 = decimal.Parse(operando1);
            decimal num2 = decimal.Parse(operando2);

            return num1 - num2;
        }
        /// Realiza a multiplicação de dois números
        public static decimal Multiplicar(string operando1, string operando2)
        {
            ValidarOperandos(operando1, operando2);

            decimal num1 = decimal.Parse(operando1);
            decimal num2 = decimal.Parse(operando2);

            return num1 * num2;
        }
        /// Realiza a divisão de dois números
        public static decimal Dividir(string operando1, string operando2)
        {
            ValidarOperandos(operando1, operando2);

            decimal num1 = decimal.Parse(operando1);
            decimal num2 = decimal.Parse(operando2);

            if (num2 == 0)
            {
                throw new DivisaoPorZeroException();
            }

            return num1 / num2;
        }
        /// Valida se os operandos são valores numéricos válidos
        private static void ValidarOperandos(string operando1, string operando2)
        {
            if (string.IsNullOrWhiteSpace(operando1) || string.IsNullOrWhiteSpace(operando2))
            {
                throw new OperandoInvalidoException();
            }

            if (!decimal.TryParse(operando1, out _) || !decimal.TryParse(operando2, out _))
            {
                throw new OperandoInvalidoException();
            }
        }
    }
}
