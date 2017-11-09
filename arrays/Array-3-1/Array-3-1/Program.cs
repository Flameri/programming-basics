using System;

namespace Array_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa 10:n numeron taulukkoon numerot 0-20 väliltä.");
            int[] x = new int[10];
            Random rnd = new Random();

            for(int i = 0; i < x.Length; i++)
            {
                x[i] = rnd.Next(0, 20);
                Console.WriteLine($"{x[i]}");
            }
            Console.ReadKey();
        }
        static int Sorter()

    }
}
