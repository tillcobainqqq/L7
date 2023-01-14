using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    internal class Pet : IPet
    {
        public Pet(string type, string name, string birthdate)
        {
            Type = type;
            Name = name;
            Birthdate = birthdate;
        }

        public string Type { get; set; }
        public string Name { get; set; }
        public string Birthdate { get; set; }
    }
}
