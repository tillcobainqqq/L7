﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    internal interface IRobot
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Id { get; set; }
    }
}
