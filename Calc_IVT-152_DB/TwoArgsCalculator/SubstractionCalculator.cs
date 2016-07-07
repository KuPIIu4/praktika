namespace Calc_IVT_152_DB.TwoArgsCalculator
{
    public class SubstractionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// calculates substraction of 2 numbers
        /// </summary>
        /// <param name="firstArgument">
        /// minuend
        /// </param>
        /// subtrahend
        /// <param name="secondArgument"></param>
        /// <returns>
        /// private
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}