using System;

namespace ConvertionTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor = "300";
            int valorConvertido = int.Parse(valor);

            Console.WriteLine(valorConvertido);

            double valor2 = 10.50;
            int valorConvertido2 = Convert.ToInt32(valor2);

            Console.WriteLine(valorConvertido2);

        }
       
    }
}
