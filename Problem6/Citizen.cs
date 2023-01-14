using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    internal class Citizen : ICitizen
    {
        public Citizen(string type, string name, string age, string id, string birthdate)
        {
            Type = type;
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string Type { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }
    }
}
