using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Citizen> citizenList = new List<Citizen>();
            List<Robot> robotList = new List<Robot>();

            string input = null;

            string idEnd = null;

            while (input != "End")
            {
                input = Console.ReadLine();
                List<string> inputList;
                inputList = input.Split(" ").ToList();

                if(inputList.Count == 3)
                {
                    Citizen citizen = new Citizen(inputList[0], inputList[1], inputList[2]);
                    citizenList.Add(citizen);
                }
                else if(inputList.Count == 2)
                {
                    Robot robot = new Robot(inputList[0], inputList[1]);
                    robotList.Add(robot);
                }
            }

            idEnd = Console.ReadLine();

            for(int i = 0; i < citizenList.Count; i++)
            {
                char[] citizenIdChar = citizenList[i].Id.ToCharArray();

                if (citizenIdChar[citizenIdChar.Length-1] == idEnd[2] && citizenIdChar[citizenIdChar.Length - 2] == idEnd[1] && citizenIdChar[citizenIdChar.Length - 3] == idEnd[0])
                {
                    Console.WriteLine(citizenList[i].Id);
                }
            }

            for (int i = 0; i < robotList.Count; i++)
            {
                char[] robotIdChar = robotList[i].Id.ToCharArray();

                if (robotIdChar[robotIdChar.Length - 1] == idEnd[2] && robotIdChar[robotIdChar.Length - 2] == idEnd[1] && robotIdChar[robotIdChar.Length - 3] == idEnd[0])
                {
                    Console.WriteLine(robotList[i].Id);
                }
            }

        }
    }
}
