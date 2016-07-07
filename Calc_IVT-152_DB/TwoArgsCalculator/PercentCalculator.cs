namespace Calc_IVT_152_DB.TwoArgsCalculator
{
    public class PercentCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// calculates percent of value
        /// </summary>
        /// <param name="firstArgument">
        /// double value
        /// </param>
        /// <param name="secondArgument">
        /// calculation percent
        /// </param>
        /// <returns>
        /// result of percent
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument / 100.0) * secondArgument * 1;
        }
    }
}
