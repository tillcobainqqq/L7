using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    internal interface IBuyer
    {
        public int Food { get; set; }
        public void BuyFood();
    }
}
