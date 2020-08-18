using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns_AbstractFactory.Fabric
{
    class ModernTable : ITable
    {
        int _legs;
        string _owner;

        public ModernTable(int legs, string owner)
        {
            _legs = legs;
            _owner = owner;
        }
        public int hasLegs()
        {
            return _legs;
        }

        public string Owner()
        {
            return _owner;
        }
    }
}
