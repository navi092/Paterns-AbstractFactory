using Paterns_AbstractFactory.Fabric;
using Paterns_AbstractFactory.Furnitur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IChair modernChair = new ModernChair(4, true);
            ISofa modernSofa = new ModernSofa(4, "Класссический диван");
            ITable modernTable = new ModernTable(4, "ООО ВИЗ-Сталь");
            IChair victoryanChar = new VictoryanChar(4, true);
            ISofa victoryanSofa = new VictoryanSofa(4, "Викториан диван");
            ITable victoryanTable = new VictoryanTable(4, "ООО ЧМЗ");

            IFurniturFactory modernFurniturFactory = new ModernFurniturFactory(modernChair, modernTable, modernSofa);
            IFurniturFactory VictoryanFurniturFactory = new VictoryaFurniturFactory(victoryanSofa, victoryanTable, victoryanChar);
            modernFurniturFactory.CreateChair();
            modernFurniturFactory.CreateCoffeeTable();
            modernFurniturFactory.CreateSofaTable();
            VictoryanFurniturFactory.CreateChair();
            VictoryanFurniturFactory.CreateCoffeeTable();
            VictoryanFurniturFactory.CreateSofaTable();
        }
    }
}
