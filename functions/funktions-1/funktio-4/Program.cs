using System;

namespace funktio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxIndex = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Suurin luku on  {Numbers(ref maxIndex)} ja se oli {maxIndex}");
            Console.ReadKey();
        }
        static int Numbers(ref int XXX)
        {
            int num = 0;
            int max = 0;
            
            bool isNumber;
            string outPut = "";
            Console.WriteLine("Syötä 10 positiivista lukua");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. ");

                if (isNumber = int.TryParse(Console.ReadLine(), out num) && num > 0)
                {
                    outPut += $"{num} "; //Luodaan palaute kaikista luvuista
                    if (max < num)
                    {
                        max = num;
                        XXX = i+1; //katsotaan mones luku oli oikein
                    }
                }
                else
                {
                    Console.WriteLine("Väärä syöte, syötä positiivinen luku");
                    i--;
                }
                
            }
            return max;
        }
    }
}
