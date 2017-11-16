using System;

namespace kertaustehtävät_16_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma kysyy lukuja, kunnes syötät kaksi samaa.");
            bool number;

            do
            {
                Console.WriteLine("Syötä luku:");
                string userInput = Console.ReadLine();
                int x = int.Parse(userInput);
                number = int.TryParse(userInput, out int y);

                if(y == y)
                {
                    Console.WriteLine("Ohjelman suoritus päättyy");
                    break;
                }
                else if(y != y)
                {
                    y++;
                }


            } while (true);


            Console.WriteLine($"");
            Console.ReadLine();
        }
    }
}