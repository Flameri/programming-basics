using System;

namespace conditional_statment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla");
            Console.Write("Syötä luku: ");
            string userInput; 
            userInput =  Console.ReadLine();

   
            int.TryParse(userInput, out int evaluatedNumber);

            Console.WriteLine("Syötit arvon {0}", userInput);
            Console.WriteLine($"Syötit arvon { userInput}");
            Console.ReadKey();
        }
    }
}
