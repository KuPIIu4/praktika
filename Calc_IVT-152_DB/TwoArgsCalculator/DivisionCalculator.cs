using System;

namespace Calc_IVT_152_DB.TwoArgsCalculator
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0.0)
            {
                throw new Exception("Деление на 0");
            }
            return firstArgument/secondArgument;
        }
    }
}
