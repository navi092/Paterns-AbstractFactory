using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Paterns_AbstractFactory.Fabric
{
    class VictoryanTable : ITable
    {
        private int _legs;
        private string _owner;
        public VictoryanTable(int legs, string owner)
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
