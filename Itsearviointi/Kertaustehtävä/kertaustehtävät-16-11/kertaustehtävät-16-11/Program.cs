using System;

namespace kertaustehtävät_16_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma kysyy lukuja, kunnes syötät kaksi samaa.");

            int newNumber = 0;
            int newNumber2 = 0;
            int i = 0;
            int sum = 0;

            do
            {
                string userInput = Console.ReadLine();

                if(i % 2 == 0)
                {
                    Console.WriteLine("Syötä luku");
                    newNumber = int.Parse(userInput);
                    sum = sum + ;
                }
                else
                {
                    Console.WriteLine("Syötä luku");
                    newNumber2 = int.Parse(userInput);
                    sum = sum + newNumber2;
                }
                i++;
            } while (newNumber != newNumber2);

            Console.WriteLine($"Syöttämiesi lukujen summa on {sum}");
            Console.ReadLine();
        }
    }
}