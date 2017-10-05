using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Ohjelma laskee lippusi hinnan antamiesi tietojen perusteella");
            
            Console.WriteLine("Syötä ikäsi: ");
            string userInput 
            userInput = Console.ReadLine();
            Console.ReadLine();
            bool isNumber;

            isNumber = int.TryParse(userInput, out int age);            
            
            double price = 16;

            double discount = 0;
            
            
             //lasketaan ikä alennukset
            if ( age < 7)
            {
                Console.WriteLine("Pääset ilmaiseksi");
            }
            else if (age >7 && age < 15)
            {
                discount = 0.5;
            }
           


            




            Console.WriteLine($"Lipun hintasi on: {price-price*discount}");
            Console.ReadKey();




        }
    }
}
