using System;

namespace Laba07_InterfacesAndAbstractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            
            IPerson person = new Citizen(age, name);

            Console.WriteLine(person.Age);
            Console.WriteLine(person.Name);

        }
    }
}
