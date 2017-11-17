using System;

namespace Array_3_2
{
    class Program
    {
        //Ohjelma oli liian nopea oli määriteltävä rnd ylemmäs
        static Random rnd = new Random();
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma arpoo kokonaislukuja kaksiulotteiseen taulukkoon");
            int[,] arr = new int[10, 20];

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; i <= 20; j++)
                {
                    if (arr[i,j] < 10)
                    {



                    }
                }
            }
            Console.ReadKey();
        }
        static string Sorter()
        {
            int y = rnd.Next(0, 100);
            string res = "";

            if (y < 10)
            {
                res = "0" + y.ToString();
            }
            else
            {
                res = y.ToString();
            }
            return res;
        }
    }
}
