using System;

namespace funktio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Syötä ohjelmalle 2 numeroa, ohjelma kertoo kumpi on pienempi.");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            int x;
            int y;
            

            int result = Calculator(x, y);
        }
        static int Calculator(int x,  int y)
        {

            if(x < y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
    }
}
