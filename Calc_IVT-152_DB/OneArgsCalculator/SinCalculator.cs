using System;

namespace Calc_IVT_152_DB.OneArgsCalculator
{
    public class SinCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}
