using Paterns_AbstractFactory.Fabric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns_AbstractFactory.Furnitur
{
    interface IFurniturFactory
    {
        IChair CreateChair();
        ITable CreateCoffeeTable();
        ISofa CreateSofaTable();
    }
}
