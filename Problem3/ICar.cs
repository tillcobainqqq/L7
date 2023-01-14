using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal interface ICar
    {
        public string DriverName { get; set; }
        public string CarModel { get; }
        public string Brakes { get; }
        public string GasPedal { get; }

    }
}
