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

            if(evaluatedNumber < 0)
            {
                Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen");
            }
            else if(evaluatedNumber > 0)
            {
             else 
            }
            Console.ReadKey();
        }
    }
}
