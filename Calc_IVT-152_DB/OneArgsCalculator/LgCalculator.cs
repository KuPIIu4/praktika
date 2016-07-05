using System;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    public class LgCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log10(firstArgument);
        }
    }
}
