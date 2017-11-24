using System;

namespace string_handling_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Syötä tekstiä");
            string userInput = Console.ReadLine();
            userInput.Replace("e", "@");

            Console.WriteLine($"Syötit tekstin: {userInput.Replace("e", "@")}");
            Console.ReadKey();
        }
    }
}
