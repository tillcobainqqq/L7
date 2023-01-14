﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Citizen : IPerson, IIdentifiable, IBirthable
    {
        public Citizen(int age, string name, string id, string birthdate)
        {
            Age = age;
            Name = name;
            Id = id;
            Birthdate = birthdate;
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }
    }
}
