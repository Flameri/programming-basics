using System;

namespace loop_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Ohjelma laskee lisäyksen. Anna luku, jonka lisäys lasketaan, laskee myös negatiiviset: ");
            string userInput = Console.ReadLine();
            //int number;
            int number = int.Parse(userInput);

            //int.TryParse(userInput, out  int number);
            int i = 0;
            int f = 0;

            if (number > 0)
            {
                do
                {
                    i = i + 1;

                    f = f + i;

                } while (i < number);
            }
            else
            {
                do
                {
                    i = i - 1;
                    f = f + i;
                } while (i > number);
            }


            Console.WriteLine($"Syötit {i}\n Vastaus on {f}");
            Console.ReadKey();
        }
    }
}
