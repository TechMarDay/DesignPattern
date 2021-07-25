using AbstractFactory.Business.Interface;

namespace AbstractFactory.Business
{
    public class PlasticFactory : FurnitureAbstractFactory
    {
        public override IChair CreateChair()
        {
            return new PlasticChair();
        }

        public override ITable CreateTable()
        {
            return new PlasticTable();
        }
    }
}