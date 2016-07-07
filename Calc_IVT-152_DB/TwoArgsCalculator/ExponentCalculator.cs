using System;

namespace Calc_IVT_152_DB.TwoArgsCalculator
{
    public class ExponentCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// raises a number to power
        /// </summary>
        /// <param name="firstArgument">
        /// number
        /// </param>
        /// <param name="secondArgument">
        /// power
        /// </param>
        /// <returns>
        /// result of powering
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument < 0.0 && secondArgument < 1 && secondArgument != 0)
            {
                throw new Exception("Не существует");
            }
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}
