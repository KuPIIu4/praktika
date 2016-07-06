using System;

namespace Calc_IVT_152_DB.TwoArgsCalc
{
    public class ExponentCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument < 0.0 && secondArgument < 1)
            {
                throw new Exception("Не существует");
            }
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}
