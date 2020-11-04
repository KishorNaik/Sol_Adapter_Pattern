using System;
using System.Collections.Generic;
using System.Text;

namespace Sol_Demo.ThirdParty
{
    public class VatTax
    {
        private const double _taxRate = 10;

        public double CalculateVat(double pricipleAmount)
        {
            return pricipleAmount * _taxRate / 100;
        }
    }
}