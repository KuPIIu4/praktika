namespace Calc_IVT_152_DB.TwoArgumentsCalculator
{
    public class SubstractionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}