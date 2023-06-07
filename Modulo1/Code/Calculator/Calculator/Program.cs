using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1;
            double valor2;
            string simboloOperacao;
            double resultado = 0;
            double calcularNovamente = 1;

            do
            {
                Console.WriteLine("Calculator");
                Console.Write("Digite o primeiro valor: ");
                valor1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo valor: ");
                valor2 = double.Parse(Console.ReadLine());

                Console.Write("Digite o símbolo (+ ou - ou / ou *) " +
                    "da operação desejada: ");
                simboloOperacao = Console.ReadLine();

                switch (simboloOperacao)
                {
                    case "+":
                        resultado = Soma(valor1, valor2);
                        break;

                    case "-":
                        resultado = Subtracao(valor1, valor2);
                        break;

                    case "/":
                        resultado = Divisao(valor1, valor2);
                        break;

                    case "*":
                        resultado = Multiplicacao(valor1, valor2);
                        break;

                    default:
                        Console.WriteLine("Operação inválida.");
                        calcularNovamente = 0;
                        break;
                }


                if (calcularNovamente == 1)
                {
                    Console.WriteLine($"Resultado: {valor1}{simboloOperacao}{valor2} = {resultado}");
                }

                Console.WriteLine($"Deseja fazer outro cálculo? 1 - SIM ou 0 - NÃO:");
                calcularNovamente = int.Parse(Console.ReadLine());
                Console.Clear();

            } while (calcularNovamente == 1);

            Console.WriteLine("Encerrando a calculadora");

        }
        
        static double Soma(double valor1, double valor2)
        {
            double resultado = valor1 + valor2;
            return resultado;

        }
        static double Subtracao(double valor1, double valor2)
        {
            double resultado = valor1 - valor2;
            return resultado;

        }
        static double Divisao(double valor1, double valor2)
        {
            double resultado = valor1 / valor2;
            return resultado;

        }
        static double Multiplicacao(double valor1, double valor2)
        {
            double resultado = valor1 * valor2;
            return resultado;

        }
        
    }
}
