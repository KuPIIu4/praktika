using System;

namespace Calc_IVT_152_DB.OneArgsCalculator
{
    public class TanCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculates tan function
        /// </summary>
        /// <param name="firstArgument">
        /// Angle in radians
        /// </param>
        /// <returns>
        /// value of tan
        /// </returns>
        public double Calculate(double firstArgument)
        {
            if ((Math.PI / 2 + firstArgument) % Math.PI == 0.0)
            {
                throw new Exception("Не существует");
            }
            return Math.Tan(firstArgument);
        }
    }
}
