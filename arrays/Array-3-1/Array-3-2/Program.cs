using System;

namespace Array_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma arpoo kokonaislukuja kaksiulotteiseen taulukkoon");
            int[,] = new int[0, 100];
        }
        static string Sorter()
        {
            int y = rnd.Next(1, 21);
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
