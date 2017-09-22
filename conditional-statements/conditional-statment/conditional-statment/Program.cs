﻿using System;

namespace conditional_statment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla");
            Console.Write("Syötä luku: ");
            string userInput;
            userInput = Console.ReadLine();


            int.TryParse(userInput, out int evaluatedNumber);

            if (evaluatedNumber < 0)
            {
                Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen");
            }
            else if (evaluatedNumber > 0)
            {
                Console.WriteLine($"Numero {evaluatedNumber} on positiivinen");
            }
            else
            {
                Console.WriteLine($"Numero {evaluatedNumber} on nolla");
            }

            Console.WriteLine($"Syötit arvon {userInput}");    
            Console.ReadKey();
        }
    }
}