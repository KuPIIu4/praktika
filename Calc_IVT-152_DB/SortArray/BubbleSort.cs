using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_IVT_152_DB.SortArray
{
    class BubbleSort : ISortArray
    {
        public void SortArray(double[] array, int length)
        {
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                {
                    if (array[i] < array[j])
                    {
                        double temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
        }
    }
}
