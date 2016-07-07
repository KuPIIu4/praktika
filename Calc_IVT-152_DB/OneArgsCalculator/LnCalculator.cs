using System;

namespace Calc_IVT_152_DB.OneArgsCalculator
{
    public class LnCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculates ln function
        /// </summary>
        /// <param name="firstArgument">
        /// double value
        /// </param>
        /// <returns>
        /// value of ln
        /// </returns>
        public double Calculate(double firstArgument)
        {
            if (firstArgument <= 0.0)
            {
                throw new Exception("Не существует");
            }
            return Math.Log(firstArgument);
        }
    }
}
