using System;

namespace loop_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Ohjelma laskee kertoman. Anna luku, jonka kertoma lasketaan: ");
            string userInput = Console.ReadLine();
            //int number;
            int number = int.Parse(userInput);

            //int.TryParse(userInput, out  int number);
            int i = 0;
            int f = 1;

            if (number < 0)
            {
                Console.WriteLine("Virheellinen syöte");
            }
            else
            {
                /*
                do
                {
                    i = i + 1;

                    f = f * i;
                    //Console.WriteLine($"{i}!= {f}"); // 5 != 120
                } while (i < number);
                */

                /*
                while (i < number)
                {
                    i = i + 1;
                    f = f * i;
                }
                */
                for (int j = 1; j <= number; j++)
                {
                    f = f * j;
                    Console.WriteLine($"{j} != {f}");
                }
                Console.WriteLine($"Syötit {number}\n vastaus {f}"); // 5 != 120
            }

            Console.ReadKey();

        }
    }
}
