using System;

namespace Calc_IVT_152_DB.TwoArgsCalculator
{
    public class ExponentCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument < 0.0 && secondArgument < 1 && secondArgument != 0)
            {
                throw new Exception("Не существует");
            }
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}
