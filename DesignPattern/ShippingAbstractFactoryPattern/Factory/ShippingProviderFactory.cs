using ShippingAbstractFactoryPattern.Enum;
using ShippingAbstractFactoryPattern.SpecificFactory;
using System;

namespace ShippingAbstractFactoryPattern.Factory
{
    public class ShippingProviderFactory
    {
        private ShippingProviderFactory()
        {
        }

        public static ShippingProviderAbstractFactory GetShippingProvider(ShippingProvider provider) //string providerName
        {
            switch (provider)
            {
                case ShippingProvider.ViettelPost:
                    //Create new ViettelPost factory
                    return new ViettelPostFactory();
                case ShippingProvider.GHN:
                    //Create new Giao hang nhanh Factory
                    return new GHNFactory();

                case ShippingProvider.GHTK:
                    //Create new Giao hang tiet kiem Factory
                    return new GHTKFactory();
                default:
                    throw new Exception("The shipping provider is unsupported");
            }
        }
    }
}