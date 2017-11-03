using System;

namespace Itsearviointi_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma kysyy lukuja kunnes syötät -1");
            int x;
            int sum = 0;
            string userInput;

            do
            {
                userInput = Console.ReadLine();
                x = int.Parse(userInput);
                sum = x + sum;
            } while (x != -1);

            Console.WriteLine($"Syötit luvun -1, syöttämiesi lukujen summa on {sum}");
            Console.ReadKey();
        }
    }
}
