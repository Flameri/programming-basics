using System;

namespace loop__example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa kokonaisluvut 1-10 ja niiden neliöjuuret: ");
            int i = 1;

            do
            {
                Console.WriteLine($"{i}\t{Math.Round(Math.Sqrt(i), 2)}");
                i++;
            }
            while (i < 11);
            Console.ReadKey();
        }
    }
}
