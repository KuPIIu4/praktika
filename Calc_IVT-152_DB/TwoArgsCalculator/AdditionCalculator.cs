namespace Calc_IVT_152_DB.TwoArgsCalculator
{
    public class AdditionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// summarizes the 2 arguments
        /// </summary>
        /// <param name="firstArgument">
        /// first value
        /// </param>
        /// <param name="secondArgument">
        /// second value
        /// </param>
        /// <returns>
        /// summ of 2 values
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
