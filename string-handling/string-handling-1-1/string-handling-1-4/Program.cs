using System;

namespace string_handling_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Syötä tekstiä");
            string userInput = Console.ReadLine().ToUpper();

            int j = 0;
            foreach(char x in userInput) 
            {
                if (x == 'L')
                    j++;
            }

            Console.WriteLine($"Tekstissäsi on {j} L- kirjainta");
            Console.ReadKey();
        }
    }
}
