using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_IVT_152_DB
{
    public class LnCalc : IOneArgCalc
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument);
        }
    }
}
