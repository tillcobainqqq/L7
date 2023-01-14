using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Citizen> citizenList = new List<Citizen>();
            List<Robot> robotList = new List<Robot>();
            List<Pet> petList = new List<Pet>();

            string input = null;

            while (input != "End")
            {
                input = Console.ReadLine();

                List<string> list = new List<string>();
                list = input.Split(" ").ToList();

                if(list[0] == "Citizen")
                {
                    Citizen citizen = new Citizen(list[0], list[1], list[2], list[3], list[4]);
                    citizenList.Add(citizen);
                }
                else if(list[0] == "Robot")
                {
                    Robot robot = new Robot(list[0], list[1], list[2]);
                    robotList.Add(robot);
                }
                else if(list[0] == "Pet")
                {
                    Pet pet = new Pet(list[0], list[1], list[2]);
                    petList.Add(pet);
                }
            }

            string year = Console.ReadLine();

            for(int i = 0; i < citizenList.Count; i++)
            {
                char[] yearChar = year.ToCharArray();
                char[] yearCharCitizen = citizenList[i].Birthdate.ToCharArray();

                if(yearChar[0] == yearCharCitizen[yearCharCitizen.Length - 4] &&
                   yearChar[1] == yearCharCitizen[yearCharCitizen.Length - 3] &&
                   yearChar[2] == yearCharCitizen[yearCharCitizen.Length - 2] &&
                   yearChar[3] == yearCharCitizen[yearCharCitizen.Length - 1])
                {
                    Console.WriteLine(citizenList[i].Birthdate);
                }
            }

            for (int i = 0; i < petList.Count; i++)
            {
                char[] yearChar = year.ToCharArray();
                char[] yearCharPet = petList[i].Birthdate.ToCharArray();

                if (yearChar[0] == yearCharPet[yearCharPet.Length - 4] &&
                    yearChar[1] == yearCharPet[yearCharPet.Length - 3] &&
                    yearChar[2] == yearCharPet[yearCharPet.Length - 2] &&
                    yearChar[3] == yearCharPet[yearCharPet.Length - 1])
                {
                    Console.WriteLine(petList[i].Birthdate);
                }
            }

        }
    }
}
