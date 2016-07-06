using System;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    public class CotCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return (1.0/Math.Tan(firstArgument));
        }
    }
}
