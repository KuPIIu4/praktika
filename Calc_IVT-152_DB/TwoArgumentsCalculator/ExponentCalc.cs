using System;

namespace Calc_IVT_152_DB.TwoArgumentsCalculator
{
    public class ExponentCalc : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}
