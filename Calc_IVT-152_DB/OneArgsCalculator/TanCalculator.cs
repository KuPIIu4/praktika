using System;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    public class TanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            if ((firstArgument % (Math.PI /2)) == 0.0)
            {
                throw new Exception("Не существует");
            }
            return Math.Tan(firstArgument);
        }
    }
}
