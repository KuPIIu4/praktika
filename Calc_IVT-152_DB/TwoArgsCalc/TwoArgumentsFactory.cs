using System;

namespace Calc_IVT_152_DB.TwoArgsCalc
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
                    return new RootCalc();
                case "buttonExponent":
                    return new ExponentCalc();
                default:
                    throw new Exception("Неизвестная мат. операция");
            }
        }
    }
}
