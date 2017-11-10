using System;

namespace Kertaustehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa annetun määrän tähtiä");
            int[] x = new int[] { 3, 5, 10, 5, 3};
            

           for(int i = 0; i < x.Length; i++)
            {
                string star = StarMachine(x[i]);
                Console.WriteLine($"{star}");
            }
            Console.ReadKey();
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