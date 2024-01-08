using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Stopwatch");
            Console.WriteLine("Type the time you wish to count and at the end 's' for seconds or 'm' for minutes or 0 to exit");
            string data = Console.ReadLine().ToLower();

            if(data != "0")
            {
                var valueLength = data.Length;

                int dataTime = int.Parse(data.Substring(0, valueLength - 1));
                string dataSecondOrMinutes = data.Substring(valueLength - 1, 1);
                Console.WriteLine(dataTime);
                Console.WriteLine(dataSecondOrMinutes);

                CheckingValue(dataTime);
                
                
                StartCountdown(dataTime,dataSecondOrMinutes);

            }
            else
            {
                Console.WriteLine("Leaving the stopwatch");
                System.Environment.Exit(0);
            }
            


        }

        static void StartCountdown(int time, string secondsOrMinutes)
        {            

            if(secondsOrMinutes == "m")
            {
                time = time * 60;
                Console.WriteLine(time);
            }
            
            int currentTime = 0;



            while (currentTime <= time)
            {
                Console.Clear();
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
                currentTime++;
            }         

            
            Console.Clear();
            Console.WriteLine("Stopwatch finished!");
            Thread.Sleep(1000);
            Menu();


        }

        static void CheckingValue(int value)
        {

            try
            {
                if (value <= 0)
                {
                    Console.WriteLine("Incorrect value");
                    Thread.Sleep(1000);

                    Menu();

                }
            }
            catch(Exception e)
            {                
                throw new ArgumentException($"The {value} is not a valid number");
            }
            
        }
    }

}
