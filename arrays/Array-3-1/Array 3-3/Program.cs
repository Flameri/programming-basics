using System;

namespace Array_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma määrittelee kolme taulukkoa, joissa on jokaisessa 10 lukua.");

            int[] arrT_1 = new int[10];
            int[] arrT_2 = new int[10];
            int[] arrT_3 = new int[10];

            Random rnd = new Random();
            

            for (int i = 0; i < 10; i++)
            {
                arrT_1[i] = rnd.Next(0, 10);
                Console.Write($"{i + 1}  {arrT_1[i]}\n");
            }
            for (int j = 0; j < 10; j++)
            {
                arrT_2[j] = rnd.Next(0, 10);
                Console.Write($" {arrT_2[j]} ");
            }


            Console.ReadKey();
        }
    }
}
