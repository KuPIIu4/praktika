using System;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    public class CosCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}
