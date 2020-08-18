using Paterns_AbstractFactory.Fabric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns_AbstractFactory.Furnitur
{
    class ModernFurniturFactory : IFurniturFactory
    {
        private ModernChair _chair;
        private ModernTable _table;
        private ModernSofa _sofa;

        public ModernFurniturFactory(ModernChair chair, ModernTable table, ModernSofa sofa)
        {
            _chair = chair;
            _table = table;
            _sofa = sofa;
        }

        public IChair CreateChair()
        {
            return _chair;
        }

        public ITable CreateCoffeeTable()
        {
            return _table;
        }

        public ISofa CreateSofa()
        {
            return _sofa;
        }
    }
}
