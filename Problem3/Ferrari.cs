using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal class Ferrari : ICar
    {
        public Ferrari(string driverName)
        {
            DriverName = driverName;
        }

        public string DriverName { get; set; }

        public string CarModel { get { return "488-Spider"; } }

        public string Brakes { get { return "Brakes!"; } }

        public string GasPedal { get { return "Zadu6avam sA!"; } }
    }
}
