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
            string userInput; 
            userInput = Console.ReadLine();

            Console.WriteLine("Oletko Mtk:n jäsen?: K/E ");
            string mtk;
            mtk = Console.ReadLine().ToUpper();

            Console.WriteLine("Oletko varusmies?: K/E ");
            string vM;
            vM = Console.ReadLine().ToUpper();

            Console.WriteLine("Oletko opiskelija?: K/E ");
            string oP;
            oP = Console.ReadLine().ToUpper();

            bool isNumber;

            isNumber = int.TryParse(userInput, out int age);            
            
            double price = 16;

            double discount = 0;

            //lasketaan ikä alennukset
            if (age < 7)
            {
                discount = 1.00;
                Console.WriteLine("Pääset ilmaiseksi");
            }
            else if (age >= 65)
            {
                discount = 0.50;
            }
            else if (age > 7 && age < 15)
            {
                discount = 0.5;
            }
            else if (mtk == "K" && oP == "K")
            {
                discount = 0.60;
            }
            else if (mtk == "K")
            {
                discount = 0.15;
            }
            else if (vM == "K")
            {
                discount = 0.50;
            }
            else if (oP == "K")
            {
                discount = 0.45;
            }
            else
            {
                Console.WriteLine("Jokin meni pieleen");
            }
                    
            Console.WriteLine($"Lipun hintasi on: {price-price*discount}");
            Console.ReadKey();
            Console.ReadKey(); 
            //Että ohjelma jää pyörimään vähän pidempään
        }
    }
}
