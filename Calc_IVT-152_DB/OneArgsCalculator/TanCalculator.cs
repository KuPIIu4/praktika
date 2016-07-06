using System;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    public class TanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            if ((((Math.PI / 2) + firstArgument) % Math.PI) == 0.0)
            {
                throw new Exception("Не существует");
            }
            return Math.Tan(firstArgument);
        }
    }
}
