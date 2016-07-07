using System;

namespace Calc_IVT_152_DB.TwoArgsCalculator
{
    public class LogCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument <= 0.0 || secondArgument == 1.0 || secondArgument <= 0)
            {
                throw new Exception("Не существует");
            }
            return (Math.Log10(firstArgument)/Math.Log10(secondArgument));
        }

    }
}
