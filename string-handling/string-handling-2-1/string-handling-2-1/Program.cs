using System;

namespace string_handling_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma laskee vokaalien määrän");
            string userInput = Console.ReadLine().ToUpper();
            char[] arr1 = new char[] {'A','E','I','O','U','Y','Ä','Ö'};
            int sum = 0;

            foreach(char x in userInput)
            {
                for(int i = 0; i < arr1.Length;i++)
                {
                    if (x == arr1[i])
                    {
                        sum++;
                    }
                }
            }
            Console.WriteLine($"Syötit sanan {userInput}, siinä on vokaaleja {sum}.");
            Console.ReadKey();
        } 
    }
}
