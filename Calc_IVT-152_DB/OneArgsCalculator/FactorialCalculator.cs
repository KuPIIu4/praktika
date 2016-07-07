using System;

namespace Calc_IVT_152_DB.OneArgsCalculator
{
    public class FactorialCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculates factorial function
        /// </summary>
        /// <param name="firstArgument">
        /// double value
        /// </param>
        /// <returns>
        /// value of factorial
        /// </returns>
        public double Calculate(double firstArgument)
        {

            if ((firstArgument - (int)firstArgument > 0.0) || firstArgument <= 0.0)
            {
                throw new Exception("Не существует");

            }
            if (firstArgument > 1)
            {
                return firstArgument*Calculate(firstArgument - 1);
            }
            else
            {
                return 1;
            }
        }
    }
}
