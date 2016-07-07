using System;

namespace Calc_IVT_152_DB.OneArgsCalculator
{
    public class LgCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument <= 0.0)
            {
                throw new Exception("Не существует");
            }
            return Math.Log10(firstArgument);
        }
    }
}
