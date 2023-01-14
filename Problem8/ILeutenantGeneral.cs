using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    internal interface ILeutenantGeneral:IPrivate
    {
        public List<Private> Privates { get; set; }
    }
}
