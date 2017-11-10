using System;

namespace Kertaustehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa annetun määrän tähtiä");
            int[] numbers = new int[{ 2, 5, 10, 7, 3 }];

           for(int i = 0; i < numbers.Length; i++)
            {

            }

        }
        static string StarMachine(int stars)
        {
            string res = string.Empty;

            for(int i= 0; i < stars; i++)
            {
                res += "*";
            }
            return res;


        }
    }
}
