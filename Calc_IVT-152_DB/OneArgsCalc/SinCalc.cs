using System;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    public class SinCalc : IOneArgCalc
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}
