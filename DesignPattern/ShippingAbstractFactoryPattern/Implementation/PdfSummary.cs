using ShippingAbstractFactoryPattern.Interface;
using System;

namespace ShippingAbstractFactoryPattern.Implementation
{
    public class PdfSummary : ISummary
    {
        public void HandleGenerateSummary()
        {
            Console.WriteLine("Create pdf summary");
        }
    }
}