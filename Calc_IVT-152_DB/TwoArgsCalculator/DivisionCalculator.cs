using System;

namespace Calc_IVT_152_DB.TwoArgsCalculator
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// divides the 2 arguments
        /// </summary>
        /// <param name="firstArgument">
        /// first value
        /// </param>
        /// <param name="secondArgument">
        /// second value
        /// </param>
        /// <returns>
        /// result of division  2 values
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0.0)
            {
                throw new Exception("Деление на 0");
            }
            return firstArgument/secondArgument;
        }
    }
}
