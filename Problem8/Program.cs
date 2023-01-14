using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Private> privateList = new List<Private>();
            List<Spy> spyList = new List<Spy>();
            List<LeutenantGeneral> leutenantGeneralList = new List<LeutenantGeneral>();
            List<Engineer> engineerList = new List<Engineer>();
            List<Commando> commandoList = new List<Commando>();
            List<Mission> missionList = new List<Mission>();
            List<Repair> repairList = new List<Repair>();

            string input = null;
            List<string> list = new List<string>();

            while (input != "End")
            {
                Console.Write("What type you want to add: ");
                input = Console.ReadLine();

                string info = null;

                switch (input)
                {
                    case "Private":
                        info = Console.ReadLine();
                        list = info.Split(" ").ToList();
                        double salary = Convert.ToDouble(list[3]);

                        Private _private = new Private(list[0], list[1], list[2], salary);
                        privateList.Add(_private);
                        break;
                ///////////////////
                    case "Spy":
                        info = Console.ReadLine();
                        list = info.Split(" ").ToList();
                        int codeNumber = Convert.ToInt32(list[3]);

                        Spy spy = new Spy(list[0], list[1], list[2], codeNumber);
                        spyList.Add(spy);
                        break;
                ///////////////////
                    case "LeutenantGeneral":
                        info = Console.ReadLine();
                        list = info.Split(" ").ToList();
                        double salary1 = Convert.ToDouble(list[3]);

                        LeutenantGeneral leutenantGeneral = new LeutenantGeneral(list[0], list[1], list[2], salary1, privateList);
                        leutenantGeneralList.Add(leutenantGeneral);
                        break;
                ///////////////////
                    case "Engineer":
                        info = Console.ReadLine();
                        list = info.Split(" ").ToList();
                        double salary2 = Convert.ToDouble(list[3]);
                        string infoCorps = Console.ReadLine();
                        List<string> corpsList = new List<string>();
                        corpsList = infoCorps.Split(" ").ToList();

                        Engineer engineer = new Engineer(list[0], list[1], list[2], salary2, corpsList, repairList);
                        engineerList.Add(engineer);
                        break;
                ///////////////////
                    case "Commando":
                        info = Console.ReadLine();
                        list = info.Split(" ").ToList();
                        double salary3 = Convert.ToDouble(list[3]);
                        string infoCorps1 = Console.ReadLine();
                        List<string> corpsList1 = new List<string>();
                        corpsList1 = infoCorps1.Split(" ").ToList();

                        Commando commando = new Commando(list[0], list[1], list[2], salary3, corpsList1, missionList);
                        commandoList.Add(commando);
                        break;
                ///////////////////
                    case "Mission":
                        info = Console.ReadLine();
                        list = info.Split(" ").ToList();

                        Mission mission = new Mission(list[0]);
                        missionList.Add(mission);
                        break;
                ///////////////////
                    case "Repair":
                        info = Console.ReadLine();
                        list = info.Split(" ").ToList();
                        int hoursWorked = Convert.ToInt32(list[1]);

                        Repair repair = new Repair(list[0], hoursWorked);
                        repairList.Add(repair);
                        break;
                }
            }

            if(privateList != null)
            {
                for(int i = 0; i < privateList.Count; i++)
                {
                    Console.WriteLine(privateList[i].ToString());
                }
            }

            if (spyList != null)
            {
                for (int i = 0; i < spyList.Count; i++)
                {
                    Console.WriteLine(spyList[i].ToString());
            }
            }

            if (leutenantGeneralList != null)
            {
                for (int i = 0; i < leutenantGeneralList.Count; i++)
                {
                    Console.WriteLine(leutenantGeneralList[i].ToString());
                }
            }

            if (engineerList != null)
            {
                for (int i = 0; i < engineerList.Count; i++)
                {
                    Console.WriteLine(engineerList[i].ToString());
                }
            }

            if (commandoList != null)
            {
                for (int i = 0; i < commandoList.Count; i++)
                {
                    Console.WriteLine(commandoList[i].ToString());
                }
            }

        }
    }
}
