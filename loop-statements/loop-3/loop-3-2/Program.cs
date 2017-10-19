using System;

namespace loop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Ohjelma laskee lisäyksen. Anna luku, jonka lisäys lasketaan: ");
            string userInput = Console.ReadLine();
            //int number;
            int number = int.Parse(userInput);

            //int.TryParse(userInput, out  int number);
            int i = 1;
            int f = 1;

            if (number < 0)
            {
                Console.WriteLine("Virheellinen syöte");
            }
            else
            {
                do
                {
                    i = i + 1;

                    f = f + i;
                    Console.WriteLine($"{i}= {f}");
                } while (i < number);
            }
            Console.ReadKey();
        }
    }
}