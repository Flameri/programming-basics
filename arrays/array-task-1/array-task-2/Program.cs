using System;

namespace array_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma arpoo 7 lukua 0-40 väliltä ja tulostaa ne pienimmästä suurimpaan, lisäksi yksi lisänumero ja tuplausnumero");
            int[] x = new int[9];
            Random rnd = new Random();
            //Viimeistä numeroa ei arvota  koska tuplaus voi olla jo arvottu
            for (int i = 0; i < x.Length - 1; i++)
            {
                x[i] = rnd.Next(1, 41);

                // Tarkistus onko luku jo arvottu
                for (int j = 0; j < i; j++)
                {
                    if (x[j] == x[i])
                    {
                        i--;
                    }
                }
            }
            x[8] = rnd.Next(1, 41);

            Array.Sort(x, null, 0,7);

            for(int i = 0; i <x.Length - 2; i++)
            {
                Console.WriteLine($"{i + 1 }. {x[i]} ");
            }
            Console.WriteLine($"Lisänumero: {x[7]} \nTuplausnumero: {x[8]}");
            Console.ReadKey();
        }
    }
}
