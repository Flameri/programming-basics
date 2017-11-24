using System;

namespace string_handling_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Syötä tekstiä.");
            string userInput = Console.ReadLine();
            Console.WriteLine($"Syötit tekstin: {userInput}, siinä on merkkejä {userInput.Length}");
            Console.ReadKey();
        }
    }
}
