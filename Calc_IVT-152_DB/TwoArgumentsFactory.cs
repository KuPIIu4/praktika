using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_IVT_152_DB
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
                default:
                    throw new Exception("Неизвестная мат. операция");
            }
        }
    }
}
