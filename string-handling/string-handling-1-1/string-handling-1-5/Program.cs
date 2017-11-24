using System;

namespace string_handling_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tarkistaa onko syöttämäsi teksti palindromi");
            string userInput = Console.ReadLine().ToUpper();
            string reverseUserInput = "";

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                //Console.WriteLine(userInput[i]);
                reverseUserInput += userInput[i];
            }
            if (userInput.Replace(" ", "") == reverseUserInput.Replace(" ", ""))
            {
                Console.WriteLine($"Syöttämäsi teksti, {userInput.ToLower()}, on palindromi");
            }
            else
            {
                Console.WriteLine($"Syöttämäsi teksti, {userInput.ToLower()}, ei ole palindromi");
            }
            Console.ReadKey();
        }
    }
}
