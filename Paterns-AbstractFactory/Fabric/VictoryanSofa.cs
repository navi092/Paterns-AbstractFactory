using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns_AbstractFactory.Fabric
{
    class VictoryanSofa : ISofa
    {
        private int _legs;
        private string _model;
        public VictoryanSofa(int legs, string model)
        {
            _legs = legs;
            _model = model;
        }
        public int hasLegs()
        {
            throw new NotImplementedException();
        }

        public string Model()
        {
            throw new NotImplementedException();
        }
    }
}
