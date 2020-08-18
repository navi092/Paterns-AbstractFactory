using Paterns_AbstractFactory.Fabric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns_AbstractFactory.Furnitur
{
    class VictoryaFurniturFactory : IFurniturFactory
    {
        private VictoryanSofa _sofa;
        private VictoryanTable _table;
        private VictoryanChair _chair;

        public VictoryaFurniturFactory(VictoryanSofa sofa, VictoryanTable table, VictoryanChair chair)
        {
            _sofa = sofa;
            _table = table;
            _chair = chair;
        }
        public IChair CreateChair()
        {
            return _chair;
        }

        public ITable CreateCoffeeTable()
        {
            return _table;
        }

        public ISofa CreateSofaTable()
        {
            return _sofa;
        }
    }
}
