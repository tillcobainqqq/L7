using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    internal class Robot : IRobot
    {
        public Robot(string type, string model, string id)
        {
            Type = type;
            Model = model;
            Id = id;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Id { get; set; }
    }
}
