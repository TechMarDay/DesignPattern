using System;

namespace FactoryMethod.Business.Factory
{
    public class ShippingProviderFactory
    {
        private ShippingProviderFactory()
        {
        }

        public static IShippingProvider GetShippingProvider(ShippingProviderEnum type)
        {
            switch (type)
            {
                case ShippingProviderEnum.GHN:
                    return new GHN();
                case ShippingProviderEnum.GHTK:
                    return new GHTK();
                default:
                    throw new Exception("This shipping provider type is unsupported");
            }
        }

    }
}