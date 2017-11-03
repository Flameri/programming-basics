using System;

namespace array_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma artoo 7 lukua 0-40 väliltä ja tulostaa ne pienimmästä suurimpaan");
            int[] x = new int[7];
            Random rnd = new Random();

            for (int i = 0; i <= 6; i++)
            {
                x[i] = rnd.Next(1, 41);
            }
            Console.WriteLine($"Arvotut numerot ovat:");

            Array.Sort(x);

            foreach(int y in x)
            {
                Console.Write(y);
                Console.Write(' ');
            }

            Console.ReadKey();
        }
    }
}
