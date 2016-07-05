using System;

namespace Calc_IVT_152_DB.TwoArgsCalc
{
    public class ExponentCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}
