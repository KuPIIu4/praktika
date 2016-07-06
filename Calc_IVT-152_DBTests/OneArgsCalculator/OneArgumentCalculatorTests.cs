using System;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    public static class OneArgumentCalculator
    {
        public static IOneArgumentCalculator CreateCalculator(string calcName)
        {
            switch (calcName)
            {
                case "buttonSin":
                    return new SinCalculator();
                case "buttonCos":
                    return new CosCalculator();
                case "buttonFact":
                    return new FactorialCalc();
                case "buttonLn":
                    return new LnCalculator();
                case "buttonLg":
                    return new LgCalculator();
                default:
                    throw new Exception("Неизвестная мат. операция");
            }
        }
    }
}
