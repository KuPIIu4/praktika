using System;

namespace Calc_IVT_152_DB.TwoArgsCalc
{
    public class LogCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (Math.Log10(firstArgument)/Math.Log10(secondArgument));
        }
    }
}
