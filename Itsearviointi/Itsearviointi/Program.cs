using System;

namespace Itsearviointi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Syötä sana tai lause ja ohjelma tulostaa sen 5 kertaa.");
            string userInput = Console.ReadLine();

            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{i}. {userInput}");
            }
            Console.ReadKey();
        }
    }
}
