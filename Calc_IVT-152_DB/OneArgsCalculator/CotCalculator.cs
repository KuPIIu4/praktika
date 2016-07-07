using System;

namespace Calc_IVT_152_DB.OneArgsCalculator
{
    public class CotCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculates cot function
        /// </summary>
        /// <param name="firstArgument">
        /// Angle in radians
        /// </param>
        /// <returns>
        /// value of cot
        /// </returns>
        public double Calculate(double firstArgument)
        {
            if ((firstArgument % Math.PI) == 0.0)
            {
                throw new Exception("Не существует");
            }

            return (1.0 / Math.Tan(firstArgument));
        }
    }
}
