using System;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    public class FactorialCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (((firstArgument - (int)firstArgument) > 0.0) || firstArgument <= 0.0)
            {
                throw new Exception("Не существует");

            }
            if (firstArgument > 1)
            {
                return firstArgument*Calculate(firstArgument - 1);
            }
            else
            {
                return 1;
            }
        }
    }
}
