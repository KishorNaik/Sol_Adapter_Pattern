using Sol_Demo.ThirdParty;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Adapters
{
    public sealed class VatTaxAdaptor : ITaxAdaptor
    {
        private readonly VatTax vatTax = null;

        public VatTaxAdaptor()
        {
            vatTax = new VatTax();
        }

        Task<double> ITaxAdaptor.CalculateTax(double principleAmount)
        {
            return Task.Run(() => vatTax.CalculateVat(principleAmount));
        }
    }
}