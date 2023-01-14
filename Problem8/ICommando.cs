using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    internal interface ICommando:ISpecialisedSoldier
    {
        public List<Mission> Missions { get; set; }
    }
}
