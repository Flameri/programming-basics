using System;

namespace string_handling_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma maksaa vokaalien määrän");
            string userInput = Console.ReadLine().ToUpper();
            string[] arr1 = new string[] { "a,e,i,o,u,y,ä,ö" };
            int i = 0;

            foreach(char x in userInput)
            {
                if (x == arr1[])
                    i++;
                    
              
                
            }

            Console.ReadKey();
        } 
    }
}
