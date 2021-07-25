using ShippingAbstractFactoryPattern.Factory;
using ShippingAbstractFactoryPattern.Implementation;
using ShippingAbstractFactoryPattern.Interface;

namespace ShippingAbstractFactoryPattern.SpecificFactory
{
    public class GHTKFactory : ShippingProviderAbstractFactory
    {
        public override void CreateInVoice()
        {
            throw new System.NotImplementedException();
        }

        public override ISummary CreateSummary()
        {
            return new EmailSummary();
        }
    }
}