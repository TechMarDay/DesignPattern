namespace FactoryMethod.Business
{
    public class GHN : IShippingProvider
    {
        public string GetName()
        {
            return "Giao hàng nhanh";
        }
    }
}