using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    internal interface ICitizen
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Id { get; set; }
    }
}
