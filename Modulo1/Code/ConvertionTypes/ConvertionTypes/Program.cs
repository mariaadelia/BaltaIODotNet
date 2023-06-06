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

            MensagemDoDia newClass = new MensagemDoDia("Funcionando a classe",4,EMes.Agosto);
            Console.WriteLine($"Mensagem: {newClass.Message}, Dia: {newClass.Days} do mês de {newClass.Mes}");

        }
    }
    struct MensagemDoDia
    {
        public MensagemDoDia(string message, int days, EMes mes)
        {
            Message = message;
            Days = days;
            Mes = mes;
        }
       
        public string Message { get; set; }
        public int Days { get; set; }
        public EMes Mes { get; set; }

    }

    enum EMes
    {
        Janeiro = 1,
        Fevereiro = 2,
        Marco = 3,
        Abril = 4,
        Maio = 5,
        Junho = 6,
        Julho = 7,
        Agosto = 8,
        Setembro = 9,
        Outubro = 10,
        Novembro = 11,
        Dezembro = 12,
    }
}
