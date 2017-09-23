using System;

namespace conditional_statment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            // Define instructions
            Console.WriteLine("Ohjema selvittää onko syötetty luku pariton vai parillinen.");
            bool isNumber;
            Console.Write("Syötä luku: ");
                //define variables
                string userInput;
                userInput = Console.ReadLine();


                isNumber = int.TryParse(userInput, out int evaluatedNumber);

            // program logic
            if (evaluatedNumber % 2 == 0)
            {
                Console.WriteLine($"Syötit luvun {evaluatedNumber}, se on parillinen");
            }
            else
            {
                Console.WriteLine($"Syötit luvun {evaluatedNumber}, se on pariton");
            }
            Console.ReadKey();  
        }
    }
}