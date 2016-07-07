using System;

namespace Calc_IVT_152_DB.OneArgsCalculator
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
                    return new FactorialCalculator();
                case "buttonLn":
                    return new LnCalculator();
                case "buttonLg":
                    return new LgCalculator();
                case "buttonTan":
                    return new TanCalculator();
                case "buttonCot":
                    return new CotCalculator();
                default:
                    throw new Exception("Неизвестная мат. операция");
            }
        }
    }
}
