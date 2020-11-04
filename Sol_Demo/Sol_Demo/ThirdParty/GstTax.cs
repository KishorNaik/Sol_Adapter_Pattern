using System;
using System.Collections.Generic;
using System.Text;

namespace Sol_Demo.ThirdParty
{
    public class GstTax
    {
        private const double _taxRate = 18;

        public double CalculateGst(double principleAmount)
        {
            return principleAmount * _taxRate / 100;
        }
    }
}