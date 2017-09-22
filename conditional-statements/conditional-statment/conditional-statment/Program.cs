using System;

namespace conditional_statment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define instructions
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla");
            bool isNumber;
            do
            {

                Console.Write("Syötä luku: ");
                //define variables
                string userInput;
                userInput = Console.ReadLine();


                 isNumber = int.TryParse(userInput, out int evaluatedNumber);


                // program logic
                if (isNumber == true)
                {
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
                }
                else
                {
                    Console.WriteLine("Syötit muuta kuin numeroita");
                    Console.WriteLine($"Syötit arvon {userInput}");
                }
            } while (isNumber == false);
            Console.ReadKey();
        }
    }
}
