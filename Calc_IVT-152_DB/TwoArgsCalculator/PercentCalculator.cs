namespace Calc_IVT_152_DB.TwoArgsCalculator
{
    public class PercentCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument / 100.0) * secondArgument * 1;
        }
    }
}
