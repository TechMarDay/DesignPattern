using ShippingAbstractFactoryPattern.Factory;
using ShippingAbstractFactoryPattern.Implementation;
using ShippingAbstractFactoryPattern.Interface;

namespace ShippingAbstractFactoryPattern.SpecificFactory
{
    public class ViettelPostFactory : ShippingProviderAbstractFactory
    {
        public override void CreateInVoice()
        {
            //Create specific Invoice for ViettelPost
            throw new System.NotImplementedException();
        }

        public override ISummary CreateSummary()
        {
            return new EmailSummary();
        }
    }
}