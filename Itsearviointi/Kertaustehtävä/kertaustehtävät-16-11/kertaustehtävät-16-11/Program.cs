﻿using System;

namespace kertaustehtävät_16_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma kysyy lukuja, kunnes syötät kaksi samaa.");

            int x = 0;
            int y = 0;
            int i = 0;
            int sum = 0;

            do
            {
                string userInput = Console.ReadLine();

                if(i % 2 == 0)
                {
                    Console.WriteLine("Syötä luku");
                    x = int.Parse(userInput);
                    sum = sum + x;
                }
                else
                {
                    Console.WriteLine("Syötä luku");
                    y = int.Parse(userInput);
                    sum = sum + y;
                }
                i++;
            } while (x != y);

            Console.WriteLine($"Syöttämiesi lukujen summa on {sum}");
            Console.ReadLine();
        }
    }
}