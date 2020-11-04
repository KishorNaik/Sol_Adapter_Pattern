using Sol_Demo.Adapters;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Contexts
{
    public enum Tax
    {
        VAT = 0,
        GST = 1
    }

    public class TaxContext
    {
        private static Dictionary<Tax, ITaxAdaptor> keyValuePairs = new Dictionary<Tax, ITaxAdaptor>();

        static TaxContext()
        {
            keyValuePairs.Add(Tax.VAT, new VatTaxAdaptor());
            keyValuePairs.Add(Tax.GST, new GstTaxAdaptor());
        }

        public async Task<double> TaxCalculation(Tax tax, double principleAmount)
        {
            return await keyValuePairs[tax].CalculateTax(principleAmount);
        }
    }
}