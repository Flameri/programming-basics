using System;

namespace Itsearviointi_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma kysyy sanan tai lauseen ja tulostaa sen niin monta kertaa kuin lauseessa on kirjaimia");
            string userInput = Console.ReadLine();

            for(int i = 1; i <= userInput.Length; i++)
            {
                Console.WriteLine($"{i}. {userInput}");
            }
            Console.ReadKey();
        }
    }
}
