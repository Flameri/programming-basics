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
            int x = rnd.Next(1 - 100);
            int guess = 0;


        }
    }
}
