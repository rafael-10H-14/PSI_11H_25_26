using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("       CALCULADORA SIMPLES EM C#");
            Console.WriteLine("═══════════════════════════════════════\n");
            bool continuar = true;
            while (continuar)
            {
                try
                {
                    // Exibir menu de operações
                    Console.WriteLine("\nEscolha uma operação:");
                    Console.WriteLine("1 - Adição (+)");
                    Console.WriteLine("2 - Subtração (-)");
                    Console.WriteLine("3 - Multiplicação (*)");
                    Console.WriteLine("4 - Divisão (/)");
                    Console.WriteLine("5 - Sair");
                    Console.Write("\nOpção: ");
                    string opcao = Console.ReadLine();
                    if (opcao == "5")
                    {
                        Console.WriteLine("\nObrigado por usar a calculadora!");
                        continuar = false;
                        break;
                    }
                    // Solicitar operandos
                    Console.Write("Digite o primeiro número: ");
                    string operando1 = Console.ReadLine();
                    Console.Write("Digite o segundo número: ");
                    string operando2 = Console.ReadLine();
                    decimal resultado = 0;
                    string nomeOperacao = "";
                    // Executar operação selecionada
                    switch (opcao)
                    {
                        case "1":
                            resultado = CalculadoraOperacoes.Adicionar(operando1, operando2);
                            nomeOperacao = "Adição";
                            break;
                        case "2":
                            resultado = CalculadoraOperacoes.Subtrair(operando1, operando2);
                            nomeOperacao = "Subtração";
                            break;
                        case "3":
                            resultado = CalculadoraOperacoes.Multiplicar(operando1, operando2);
                            nomeOperacao = "Multiplicação";
                            break;
                        case "4":
                            resultado = CalculadoraOperacoes.Dividir(operando1, operando2);
                            nomeOperacao = "Divisão";
                            break;
                        default:
                            throw new OperacaoInvalidaException(opcao);
                    }
                    // Exibir resultado
                    Console.WriteLine("\n" + new string('─', 40));
                    Console.WriteLine($"Operação: {nomeOperacao}");
                    Console.WriteLine($"{operando1} {GetSimbolo(opcao)} {operando2} = {resultado:F2}");
                    Console.WriteLine(new string('─', 40));
                }
                catch (OperandoInvalidoException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n❌ {ex.Message}");
                    Console.ResetColor();
                }
                catch (DivisaoPorZeroException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n❌ {ex.Message}");
                    Console.ResetColor();
                }
                catch (OperacaoInvalidaException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n❌ {ex.Message}");
                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n❌ Erro inesperado: {ex.Message}");
                    Console.ResetColor();
                }
            }
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
        /// Retorna o símbolo da operação
        private static string GetSimbolo(string opcao)
        {
            return opcao switch
            {
                "1" => "+",
                "2" => "-",
                "3" => "*",
                "4" => "/",
                "5" => "?"
            };
        }
    }
}
