using System;

namespace Calc_IVT_152_DB.TwoArgsCalculator
{
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calcName)
        {
            switch (calcName)
            {
                case "buttonAdd":
                    return new AdditionCalculator();
                case "buttonSub":
                    return new SubstractionCalculator();
                case "buttonMult":
                    return new MultiplyCalculator();              
                case "buttonDiv":
                    return new DivisionCalculator();
                case "buttonRoot":
                    return new RootCalculator();
                case "buttonExponent":
                    return new ExponentCalculator();
                case "buttonPercent":
                    return new PercentCalculator();
                case "buttonLog":
                    return new LogCalculator();
                default:
                    throw new Exception("Неизвестная мат. операция");
            }
        }
    }
}
