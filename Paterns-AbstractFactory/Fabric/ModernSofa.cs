using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns_AbstractFactory.Fabric
{
    class ModernSofa : ISofa
    {
        private int _legs;
        private string _model;

        public ModernSofa(int legs, string model)
        {
            _legs = legs;
            _model = model;
        }

        public int hasLegs()
        {
            return _legs;
        }

        public string Model()
        {
            return _model;
        }
    }
}
