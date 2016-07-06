namespace Calc_IVT_152_DB.TwoArgsCalc
{
    public class PercentCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument / 100.0) * secondArgument*1;
        }
    }
}
