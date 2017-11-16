using System;

namespace Kertaustehtävä_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Minäpä tiedän luvun väliltä 1-00 jota sinä et tiedä!");
            Random rnd = new Random();
            int x = rnd.Next(1,101);
            int guess = 0;
            int y;

            do
            {
                Console.WriteLine("Arvaa luku:");
                string userInput = Console.ReadLine();
                y = int.Parse(userInput);
                guess++;

                if (x == y)
                {
                    Console.WriteLine($"Arvasit oikein! Arvasit {guess} kertaa");
                }
                else if (x < y)
                {
                    Console.WriteLine("Lukuni on pienempi");
                }
                else if (x > y)
                {
                    Console.WriteLine("Lukuni on suurempi");
                }
            } while (x != y);

           
            Console.ReadLine();
        }
    }
}
