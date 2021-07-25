using AbstractFactory.Business.Interface;

namespace AbstractFactory.Business
{
    public abstract class FurnitureAbstractFactory
    {
        public abstract IChair CreateChair();

        public abstract ITable CreateTable();
    }
}