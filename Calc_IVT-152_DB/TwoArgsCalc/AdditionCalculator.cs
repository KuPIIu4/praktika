namespace Calc_IVT_152_DB.TwoArgsCalc
{
    public class AdditionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
