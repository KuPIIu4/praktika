using System;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    public class LnCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument);
        }
    }
}
