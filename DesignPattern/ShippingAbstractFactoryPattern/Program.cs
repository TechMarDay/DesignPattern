using ShippingAbstractFactoryPattern.Enum;
using ShippingAbstractFactoryPattern.Factory;
using System;

namespace ShippingAbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var viettelPost = ShippingProviderFactory.GetShippingProvider(ShippingProvider.ViettelPost);

            var viettelPostSummary = viettelPost.CreateSummary();

            viettelPostSummary.HandleGenerateSummary();

            var ghtk = ShippingProviderFactory.GetShippingProvider(ShippingProvider.GHTK);

            var ghtkSummary = ghtk.CreateSummary();

            ghtkSummary.HandleGenerateSummary();

            var ghn = ShippingProviderFactory.GetShippingProvider(ShippingProvider.GHN);

            var ghnSummary = ghn.CreateSummary();

            ghnSummary.HandleGenerateSummary();

            Console.ReadLine();
        }
    }
}
