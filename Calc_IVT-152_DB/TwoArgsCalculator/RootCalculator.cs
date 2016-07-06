using System;

namespace Calc_IVT_152_DB.TwoArgsCalc
{
    public class RootCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument < 0.0)
            {
                throw new Exception("Не существует");
            }
            return Math.Pow(firstArgument, (1.0/secondArgument));
        }
    }
}
