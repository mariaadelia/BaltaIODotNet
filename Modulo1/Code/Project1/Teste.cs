using System;
//Mesmo namespace em outro arquivo
namespace Project1
{
    class Teste
    {
        public void MetodoTeste()
        {
            var message = "estamos na classe teste";
            Console.WriteLine(message);
        }
        public String TestandoReturn()
        {
            string x = "Testando o return";
            return x;
        }
    }
}
