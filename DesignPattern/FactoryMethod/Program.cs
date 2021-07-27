using FactoryMethod.Business.Factory;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory method");

            var shippingProvider = ShippingProviderFactory.GetShippingProvider(Business.ShippingProviderEnum.GHN);
            Console.WriteLine(shippingProvider.GetName());
            Console.ReadLine();
        }
    }
}
