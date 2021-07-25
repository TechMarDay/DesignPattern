using ShippingAbstractFactoryPattern.Interface;
using System;

namespace ShippingAbstractFactoryPattern.Implementation
{
    public class EmailSummary : ISummary
    {
        public void HandleGenerateSummary()
        {
            Console.WriteLine("Create email summary");
        }
    }
}