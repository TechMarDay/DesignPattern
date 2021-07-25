using ShippingAbstractFactoryPattern.Factory;
using ShippingAbstractFactoryPattern.Implementation;
using ShippingAbstractFactoryPattern.Interface;

namespace ShippingAbstractFactoryPattern.SpecificFactory
{
    public class GHNFactory : ShippingProviderAbstractFactory
    {
        public override void CreateInVoice()
        {
            throw new System.NotImplementedException();
        }

        public override ISummary CreateSummary()
        {
            return new PdfSummary();
        }
    }
}