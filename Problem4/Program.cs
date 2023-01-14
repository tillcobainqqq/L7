using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();
            List<string> number;
            number = numberString.Split(" ").ToList();

            string uRLString = Console.ReadLine();
            List<string> uRL;
            uRL = uRLString.Split(" ").ToList();

            Smartphone smartphone = new Smartphone(number, uRL);

            for (int i = 0; i < smartphone.Number.Count; i++)
            {
                char[] numberI = smartphone.Number[i].ToCharArray();
                for (int j = 0; j < numberI.Length; j++)
                {
                    if (char.IsLetter(numberI[j]))
                    {
                        smartphone.Number[i] = "Invalid number!";
                    }
                }
            }
            for(int i = 0; i < smartphone.Number.Count; i++)
            {
                Console.Write("Calling... ");
                Console.WriteLine(smartphone.Number[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < smartphone.URL.Count; i++)
            {
                char[] urlI = smartphone.URL[i].ToCharArray();
                for (int j = 0; j < urlI.Length; j++)
                {
                    if (char.IsNumber(urlI[j]))
                    {
                        smartphone.URL[i] = "Invalid url!";
                    }
                }
            }
            for(int i = 0; i < smartphone.URL.Count; i++)
            {
                Console.Write("Browsing: ");
                Console.WriteLine(smartphone.URL[i]);
            }
        }
    }
}
