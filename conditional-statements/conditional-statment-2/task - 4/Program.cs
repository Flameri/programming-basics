using System;

namespace task___4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Syötä 3 lukua ohjelma lajittelee luvut nousevaan järjestykseen.");


            Console.Write("Syötä luku 1: ");
            string num1 = Console.ReadLine();
            int numX = int.Parse(num1);


            Console.Write("Syötä luku 2: ");
            string num2 = Console.ReadLine();
            int numY = int.Parse(num2);

            Console.Write("Syötä luku 3: ");
            string num3 = Console.ReadLine();
            int numZ = int.Parse(num3);

            if (numX < numY)
            {
                if (numX < numZ)
                {
                    if (numY < numZ)
                    {
                        Console.WriteLine($"{numX}, {numY}, {numZ}");
                    }
                    else
                    {
                        Console.WriteLine($"{numX}, {numZ}, {numY}");
                    }
                }
                else
                {
                    Console.WriteLine($"{numZ}, {numX}, {numY},");
                }

            }




            else
            {
                if (numX < numZ)
                {
                    Console.WriteLine($"{numY},{numX},{numZ}");
                }
                else
                {
                    if (numY < numZ)
                    {
                        Console.WriteLine($"{numY},{numZ},{numX}");
                    }

                    else
                    {
                        Console.WriteLine($"{numZ},{numY},{numX}");
                    }
                }
  
            }
                     Console.ReadKey();
        }
    }
}

                





                


    
