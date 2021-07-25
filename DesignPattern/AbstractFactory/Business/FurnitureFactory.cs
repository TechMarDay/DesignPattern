using AbstractFactory.Business.Enum;
using System;

namespace AbstractFactory.Business
{
    public class FurnitureFactory
    {
        private FurnitureFactory()
        {
        }

        public static FurnitureAbstractFactory GetFactory(MaterialType type)
        {
            return type switch
            {
                MaterialType.PLASTIC => new PlasticFactory(),
                MaterialType.WOOD => new WoodFactory(),
                _ => throw new Exception("This furniture is unsupported"),
            };
        }
    }
}