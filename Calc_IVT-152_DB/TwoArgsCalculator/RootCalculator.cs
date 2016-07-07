using System;

namespace Calc_IVT_152_DB.TwoArgsCalculator
{
    public class RootCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// calculates root of number
        /// </summary>
        /// <param name="firstArgument">
        /// double value
        /// </param>
        /// <param name="secondArgument">
        /// exponent of root
        /// </param>
        /// <returns>
        /// result of root
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument < 0.0)
            {
                throw new Exception("Не существует");
            }
            return Math.Pow(firstArgument, (1.0/secondArgument));
        }
    }
}
