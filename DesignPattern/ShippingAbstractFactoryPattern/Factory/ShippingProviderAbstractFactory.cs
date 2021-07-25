using ShippingAbstractFactoryPattern.Interface;

namespace ShippingAbstractFactoryPattern.Factory
{
    public abstract class ShippingProviderAbstractFactory
    {
        public abstract void CreateInVoice();

        public abstract ISummary CreateSummary();
    }
}