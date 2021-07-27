namespace FactoryMethod.Business
{
    public class GHTK : IShippingProvider
    {
        public string GetName()
        {
            return "Giao hàng tiết kiệm";
        }
    }
}