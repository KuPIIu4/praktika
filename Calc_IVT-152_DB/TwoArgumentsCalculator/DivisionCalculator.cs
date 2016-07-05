namespace Calc_IVT_152_DB.TwoArgumentsCalculator
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument / secondArgument;
        }
    }
}
