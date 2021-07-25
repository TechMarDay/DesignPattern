using AbstractFactory.Business;
using AbstractFactory.Business.Enum;

namespace AbstractFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FurnitureAbstractFactory factory = FurnitureFactory.GetFactory(MaterialType.WOOD);

            var chair = factory.CreateChair();
            chair.Create();

            var table = factory.CreateTable();
            table.Create();
        }
    }
}