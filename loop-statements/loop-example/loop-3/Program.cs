using System;

namespace loop_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Ohjelma laskee ensimmäisen parittoman ja parillisen lukujen summan: ");
            string userInput = Console.ReadLine();
            //int number;
            int number = int.Parse(userInput);

            //int.TryParse(userInput, out  int number);
            int i = 1;
            int evenSum = 0;
            int oddSum = 0;
            do
            {
                if (i % 2 == 0)
                    evenSum += i;

                else
                    oddSum += i;

                i++;
            }
            while (i <= number);

            Console.WriteLine($"Parillisten lukujen summa = {evenSum} ja parittomien lukujen summa = {oddSum}");
          
            Console.ReadKey();
        }
    }
}
