using System;

namespace array_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma arpoo 100 lukua 0-50 väliltä ja ilmoittaa luvut ja niiden keskiarvon");
            int[] iT = new int[100];
            double sum = 0;
            Random rnd = new Random();

            for (int i = 0; i < iT.Length; i++)
            {
                iT[i] = rnd.Next(0, 50);
                Console.WriteLine($"{i + 1}. {iT[i]}");
            }
            for (int i = 0; i < iT.Length; i++)
            {
                sum += iT[i];
            }


            Console.WriteLine($"{sum}  \n{sum/100}");
            Console.ReadKey(); 
        }
    }
}
