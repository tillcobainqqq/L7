using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Citizen> citizenList = new List<Citizen>();
            List<Rebel> rebelList = new List<Rebel>();

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                List<string> list = new List<string>();

                list = input.Split(" ").ToList();

                if(list.Count == 4)
                {
                    Citizen citizen = new Citizen(list[0], list[1], list[2], list[3]);
                    citizenList.Add(citizen);
                }
                else if(list.Count == 3)
                {
                    Rebel rebel = new Rebel(list[0], list[1], list[2]);
                    rebelList.Add(rebel);
                }
            }

            string input1 = null;
            int total = 0;

            while(input1 != "End")
            {
                input1 = Console.ReadLine();

                for(int i = 0; i < citizenList.Count; i++)
                {
                    if(input1 == citizenList[i].Name)
                    {
                        citizenList[i].BuyFood();
                    }
                }
                for(int i = 0; i < rebelList.Count; i++)
                {
                    if(input1 == rebelList[i].Name)
                    {
                        rebelList[i].BuyFood();
                    }
                }
            }

            if (citizenList != null)
            {
                for (int i = 0; i < citizenList.Count; i++)
                {
                    total += citizenList[i].Food;
                }
            }

            if (rebelList != null)
            {
                for (int i = 0; i < rebelList.Count; i++)
                {
                    total += rebelList[i].Food;
                }
            }

            Console.WriteLine(total);
        }
    }
}
