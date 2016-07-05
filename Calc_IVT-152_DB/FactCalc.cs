using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_IVT_152_DB
{
    public class FactCalc : IOneArgCalc
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
