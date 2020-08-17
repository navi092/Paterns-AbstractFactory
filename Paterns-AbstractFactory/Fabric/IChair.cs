using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns_AbstractFactory.Fabric
{
    interface IChair
    {
        int hasLegs();
        bool sitOn();
    }
}
