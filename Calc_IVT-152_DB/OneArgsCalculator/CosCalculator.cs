using System;

namespace Calc_IVT_152_DB.OneArgsCalculator
{
    public class CosCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}
