namespace Calc_IVT_152_DB.TwoArgsCalculator
{
    public class MultiplyCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Multiplies 2 values
        /// </summary>
        /// <param name="firstArgument">
        /// first double value
        /// </param>
        /// <param name="secondArgument">
        /// second double value
        /// </param>
        /// <returns>
        /// result of multiplication
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}
