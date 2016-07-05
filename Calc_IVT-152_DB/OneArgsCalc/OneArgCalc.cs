using System;

namespace Calc_IVT_152_DB.OneArgsCalc
{
    public static class OneArgCalc
    {
        public static IOneArgCalc CreateCalculator(string calcName)
        {
            switch (calcName)
            {
                case "buttonSin":
                    return new SinCalc();
                case "buttonCos":
                    return new CosCalc();
                case "buttonFact":
                    return new FactCalc();
                case "buttonLn":
                    return new LnCalc();
                case "buttonLg":
                    return new LgCalc();
                default:
                    throw new Exception("Неизвестная мат. операция");
            }
        }
    }
}
