using System;

namespace Array_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma määrittelee kolme taulukkoa, joissa on jokaisessa 10 lukua.\n");

            int[] arrT_1 = new int[10];
            int[] arrT_2 = new int[10];
            int[] arrT_3 = new int[10];

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                arrT_1[i] = rnd.Next(0, 51);
                //Console.Write($"{i + 1} {Printer(arrT_1[i])}");
            }
            for (int i = 0; i < 10; i++)
            {
                arrT_2[i] = rnd.Next(0, 51);
                //Console.Write($"{Printer(arrT_2[i])} ");
            }
             for (int i = 0; i < 10; i++)
             {
                if (arrT_1[i] < arrT_2[i])
                {
                    arrT_3[i] = arrT_2[i];
                }
                else
                {
                    arrT_3[i] = arrT_1[i];
                }
             }
            //0-10 numeroiden yläpuolelle
            Console.Write("         ");
             for(int i = 1; i <= 10; i++)
             {
                if(i < 10)
                {
                    Console.Write($" 0{i} ");
                }
                else
                {
                    Console.Write($" {i}\n ");
                }
             }
            Console.Write("         ---------------------------------------\n"); // --- numeroiden alle
            Console.WriteLine($"arrT_1:  {Printer(arrT_1)}\narrT_2:  {Printer(arrT_2)}\narrT_3:  {Printer(arrT_3)}");

             Console.ReadKey();
         }
         static string Printer(int [] arrX)
         {
            string res = "";

            for (int i = 0; i < arrX.Length; i++)
            {
                res += $" {arrX[i]:00} ";
            }

            
             return res; 
         }
    }
}
