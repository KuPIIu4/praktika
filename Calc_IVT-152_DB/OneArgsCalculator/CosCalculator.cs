using System;

namespace Calc_IVT_152_DB.OneArgsCalculator
{
    public class CosCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculates cos function
        /// </summary>
        /// <param name="firstArgument">
        /// Angle in radians
        /// </param>
        /// <returns>
        /// value of cos
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}
