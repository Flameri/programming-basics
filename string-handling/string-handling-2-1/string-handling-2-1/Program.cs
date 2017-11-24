using System;

namespace string_handling_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma maksaa vokaalien määrän");
            string userInput = Console.ReadLine().ToUpper();

        }
    }
}
