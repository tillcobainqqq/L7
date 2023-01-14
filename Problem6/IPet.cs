using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    internal interface IPet
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Birthdate { get; set; }
    }
}
