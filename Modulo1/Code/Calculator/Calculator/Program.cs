using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuInicial();

        }

        static void MenuInicial()
        {
            double valor1;
            double valor2;
            string simboloOperacao;           

            Console.Write("Digite o primeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o símbolo (+ ou - ou / ou *) " +
                "da operação desejada: ");
            simboloOperacao = Console.ReadLine();

            OpcaoOperacao(valor1, valor2, simboloOperacao);

            NovaOperacao();

        }

        static void OpcaoOperacao(double valorOp1, double valorOp2, string simbolo)
        {
            switch (simbolo)
            {
                case "+":
                    Soma(valorOp1, valorOp2);
                    break;

                case "-":
                    Subtracao(valorOp1, valorOp2);
                    break;

                case "/":
                    Divisao(valorOp1, valorOp2);
                    break;

                case "*":
                    Multiplicacao(valorOp1, valorOp2);
                    break;

                default:
                    Operacaoinvalida();
                    break;
            }
        }
        static void Operacaoinvalida()
        {
            Console.WriteLine("Operação inválida.");
        }
        static void NovaOperacao()
        {
            string calcularNovamente;

            Console.Write($"Deseja fazer outro cálculo? Digit 1 para 'sim' ou outras teclas para sair :");
            calcularNovamente = Console.ReadLine();

            if (calcularNovamente == "1")
            {
                Console.Clear();
                MenuInicial();
            }
            else
            {
                Console.WriteLine("Encerrando a calculadora");
                System.Environment.Exit(0);
            }
            
            

        }

        //Operações
        static double Soma(double valor1, double valor2)
        {
            double resultado = valor1 + valor2;
            Console.WriteLine($"Resultado: {valor1}+{valor2} = {resultado}");
            return resultado;

        }
        static double Subtracao(double valor1, double valor2)
        {
            double resultado = valor1 - valor2;
            Console.WriteLine($"Resultado: {valor1}-{valor2} = {resultado}");
            return resultado;

        }
        static double Divisao(double valor1, double valor2)
        {
            double resultado = valor1 / valor2;
            Console.WriteLine($"Resultado: {valor1}/{valor2} = {resultado}");
            return resultado;

        }
        static double Multiplicacao(double valor1, double valor2)
        {
            double resultado = valor1 * valor2;
            Console.WriteLine($"Resultado: {valor1}*{valor2} = {resultado}");
            return resultado;

        }
        
    }
}
