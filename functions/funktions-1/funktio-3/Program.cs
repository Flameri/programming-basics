using System;

namespace funktio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int retNumber = numberFromRange(1, 50);
            Console.WriteLine($"Syöttämäsi luku {retNumber} on sallittu");
            Console.ReadKey();

        }
        static int NumberFromRange(int lowerBound, int upperBound)
        {
            bool isNumber;
            int input = 0;
            int ret = 0;

            do
            {
                Console.Write("Syötä numero väliltä 1-50: ");
                isNumber = int.TryParse(Console.ReadLine(), out input);

               
                if (input >= lowerBound && input <= upperBound)
                {
                    ret = input;
                    break;
                }
                else
                {
                    
                    isNumber = false;
                }
            }
            while (isNumber == false);

            return ret;
        }
    }
}
