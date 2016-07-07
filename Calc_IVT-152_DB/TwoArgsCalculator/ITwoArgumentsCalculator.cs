namespace Calc_IVT_152_DB.TwoArgsCalculator
{
    public interface ITwoArgumentsCalculator
    {
        /// <summary>
        /// interface of calculator
        /// </summary>
        /// <param name="firstArgument">
        /// first double argument
        /// </param>
        /// <param name="secondArgument">
        /// second double argument
        /// </param>
        /// <returns>
        /// result of caclculating 2 arguments
        /// </returns>
        double Calculate(double firstArgument, double secondArgument);
    }
}
