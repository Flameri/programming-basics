using System;

namespace string_handling_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string userInput = "Hello World!";
            userInput.ToLower();
            userInput.ToUpper();
            userInput.Trim();
            

            Console.WriteLine($"{userInput[6]} {userInput[5]} {userInput[4]} {userInput[3]} {userInput[2]} {userInput[1]}");
            Console.WriteLine($"{userInput.Length}");
            Console.WriteLine($"{userInput.ToLower()}");
            Console.WriteLine($"{userInput.ToUpper()}");
            Console.WriteLine($"{userInput.Trim()}");
            Console.WriteLine($"{userInput.Substring(6)}");
            Console.ReadKey();
        }
    }
}
