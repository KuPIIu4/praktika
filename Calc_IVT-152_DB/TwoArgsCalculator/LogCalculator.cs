using System;

namespace Calc_IVT_152_DB.TwoArgsCalculator
{
    public class LogCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// calculates log function
        /// </summary>
        /// <param name="firstArgument">
        /// param of log
        /// </param>
        /// <param name="secondArgument">
        /// base of log
        /// </param>
        /// <returns>
        /// result of log function
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument <= 0.0 || secondArgument == 1.0 || secondArgument <= 0)
            {
                throw new Exception("Не существует");
            }
            return (Math.Log10(firstArgument)/Math.Log10(secondArgument));
        }

    }
}
