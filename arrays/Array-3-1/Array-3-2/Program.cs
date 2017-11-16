using System;

namespace Array_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma arpoo kokonaislukuja kaksiulotteiseen taulukkoon");
            int[,] arr = new int[0, 100];

            for (int i = 0; i < 100; i++)
            {
               arr[i] = Sorter();
                Console.WriteLine($"{i + 1} = {arr[i]}");
            }
            Console.ReadKey();
        }
        static string Sorter()
        {
            int y = rnd.Next(1, 21);
            string res = "";

            if (y < 10)
            {
                res = "0" + y.ToString();
            }
            else
            {
                res = y.ToString();
            }
            return res;
        }
    }
}
