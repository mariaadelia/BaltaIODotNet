using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "testando o break point";
            Console.WriteLine($"{texto}");
            Teste teste = new Teste();
            teste.MetodoTeste();

            var message = teste.TestandoReturn();
            Console.WriteLine($"{message}");
        }
    }
}
