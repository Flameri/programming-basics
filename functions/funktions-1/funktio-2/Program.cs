using System;

namespace funktio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Syötä ohjelmalle 2 numeroa, ohjelma kertoo kumpi on pienempi.");
            Console.WriteLine("Syötä ensimmäinen luku");
            string userInput = Console.ReadLine();
            int x = int.Parse(userInput);
            Console.WriteLine("Syötä toinen luku");
            string userInput2 = Console.ReadLine();
            int y = int.Parse(userInput2);
            
            
           
            int p = Calculator(x, y);

            if(p == x && x != y)
            {
                Console.WriteLine($"{x} on pienempi kuin {y}");
            }
            else if(p == y && y != x)
            {
                Console.WriteLine($"{y} on pienempi kuin {x}");
            }
            else
            {
                Console.WriteLine($"{x} on yhtäsuuri kuin {y}");
            }
            Console.ReadKey();

        }
        static int Calculator(int x,  int y)
        {

            if(x < y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
    }
}
