﻿using System;

namespace Calc_IVT_152_DB.TwoArgumentsCalculator
{
    public class RootCalc : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, (1.0/secondArgument));
        }
    }
}
