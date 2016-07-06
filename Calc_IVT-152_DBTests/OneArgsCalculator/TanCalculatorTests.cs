using System;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    public class TanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument);
        }
    }
}
