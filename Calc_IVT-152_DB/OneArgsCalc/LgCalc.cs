using System;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    public class LgCalc : IOneArgCalc
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log10(firstArgument);
        }
    }
}
