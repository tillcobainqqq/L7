using System;

namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string driverName = Console.ReadLine();

            ICar ferrari = new Ferrari(driverName);

            Console.Write(ferrari.CarModel + "/");
            Console.Write(ferrari.Brakes + "/");
            Console.Write(ferrari.GasPedal + "/");
            Console.Write(ferrari.DriverName);
        }
    }
}
