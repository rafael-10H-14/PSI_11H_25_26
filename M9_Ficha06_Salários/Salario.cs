using System;

namespace M9_Ficha06_Salários
{
    public class Salario
    {
        public double salarioBruto;
        public double descontoSegSocial;
        public double descontoIRS;
        public double salarioLiquido;

        // Construtor
        public Salario()
        {
            salarioBruto = 0.0;
            descontoSegSocial = 0.0;
            descontoIRS = 0.0;
            salarioLiquido = 0.0;
        }

        // Destrutor (finalizador)
        ~Salario()
        {
            // Aquí poderia ser usado para liberar recursos não gerenciados, se existissem.
        }

        // Método que realiza os cálculos dos descontos e do salário líquido
        public void Calcular()
        {
            // Segurança Social = 20% do salário bruto
            descontoSegSocial = salarioBruto * 0.20;

            // IRS conforme tabela
            if (salarioBruto < 500.0)
            {
                descontoIRS = 0.0;
            }
            else if (salarioBruto >= 500.0 && salarioBruto < 1500.0)
            {
                descontoIRS = salarioBruto * 0.12;
            }
            else // superior a 1500€
            {
                descontoIRS = salarioBruto * 0.18;
            }

            salarioLiquido = salarioBruto - descontoSegSocial - descontoIRS;
        }
    }
}