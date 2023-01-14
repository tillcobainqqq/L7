using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    internal class Smartphone : INumber, IURL
    {
        public Smartphone(List<string> number, List<string> uRL)
        {
            Number = number;
            URL = uRL;
        }

        public List<string> Number { get; set; }
        public List<string> URL { get; set; }
    }
}
