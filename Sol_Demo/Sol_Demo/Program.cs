using Sol_Demo.Contexts;
using System;
using System.Threading.Tasks;

namespace Sol_Demo
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            double principleAmount = 1000;

            var taxContext = new TaxContext();

            double taxValue = await taxContext.TaxCalculation(Tax.GST, principleAmount);

            Console.WriteLine($"GST : {taxValue}");

            taxValue = await taxContext.TaxCalculation(Tax.VAT, principleAmount);

            Console.WriteLine($"Vat : {taxValue}");
        }
    }
}