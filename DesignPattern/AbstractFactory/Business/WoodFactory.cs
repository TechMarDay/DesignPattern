using AbstractFactory.Business.Interface;

namespace AbstractFactory.Business
{
    public class WoodFactory : FurnitureAbstractFactory
    {
        public override IChair CreateChair()
        {
            return new WoodChair();
        }

        public override ITable CreateTable()
        {
            return new WoodTable();
        }
    }
}