using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            StartCountdown();
        }

        static void InputUser()
        {
            //Definir o valor que o usuário deseja colocar no stopwatch
        }
        static void StartCountdown()
        {
            //Countdown baseado no input do usuário
            int time = 10;
            int currentTime = 0;

            while (currentTime <= time)
            {
                Console.Clear();
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
                currentTime++;
            }

        }
    }

}
