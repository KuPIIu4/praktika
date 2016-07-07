using System;

namespace Calc_IVT_152_DB.OneArgsCalculator
{
    public class SinCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculates sin function
        /// </summary>
        /// <param name="firstArgument">
        /// Angle in radians
        /// </param>
        /// <returns>
        /// value of sin
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}
