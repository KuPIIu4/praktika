using System;

namespace Calc_IVT_152_DB.TwoArgsCalc
{
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calcName)
        {
            switch (calcName)
            {
                /*case "buttonAdd":
                    return new AdditionCalculatorTest();*/
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
                default:
                    throw new Exception("Неизвестная мат. операция");
            }
        }
    }
}
