using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Adapters
{
    public interface ITaxAdaptor
    {
        Task<double> CalculateTax(double principleAmount);
    }
}