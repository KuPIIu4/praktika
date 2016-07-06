namespace Calc_IVT_152_DB.OneArgsCalc
{
    public class FactorialCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument > 1)
            {
                return firstArgument*Calculate(firstArgument - 1);
            }
            else
            {
                return 1;
            }
        }
    }
}
