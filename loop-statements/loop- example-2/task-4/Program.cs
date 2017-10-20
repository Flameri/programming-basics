using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Ohjelma simuloi rahan heittoa: ");
            int.TryParse(Console.ReadLine(), out int n);
            int kruuna = 1;
            int klaava = 1;
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                if (rnd.Next(2) == 1)
                {
                    kruuna++;
                }
                else
                {
                    klaava++;
                }
                Console.WriteLine($"Kolikkoa on heitetty {n} kertaa.\n Klaavoja tuli {klaava} kruunia tuli {kruuna}");
                Console.ReadKey();
            }
        }
    }
}
