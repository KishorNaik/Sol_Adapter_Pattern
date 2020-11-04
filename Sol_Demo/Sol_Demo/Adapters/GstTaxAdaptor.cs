using Sol_Demo.ThirdParty;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Adapters
{
    public sealed class GstTaxAdaptor : ITaxAdaptor
    {
        private readonly GstTax gstTax = null;

        public GstTaxAdaptor()
        {
            this.gstTax = new GstTax();
        }

        Task<double> ITaxAdaptor.CalculateTax(double principleAmount)
        {
            return Task.Run(() => gstTax.CalculateGst(principleAmount));
        }
    }
}