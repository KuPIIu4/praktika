using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_IVT_152_DB.SortArray
{
    public class BubbleSort : ISortArray
    {
        public void SortArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length; j++)
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
