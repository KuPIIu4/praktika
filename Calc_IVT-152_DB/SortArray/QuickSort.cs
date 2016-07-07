namespace Calc_IVT_152_DB.SortArray
{
    public class QuickSort : ISortArray
    {
        /// <summary>
        /// sorts array by quick method
        /// </summary>
        /// <param name="array">
        /// pointer to double array
        /// </param>
        public void SortArray(double[] array)
        {
            sort(array, 0, array.Length - 1);
        }
        private void sort(double[] array, int l, int r)
        {
            double x = array[l + (r - l) / 2];
            int i = l;
            int j = r;
            while (i <= j)
            {
                while (array[i] < x)
                {
                    i++;
                }
                while (array[j] > x)
                {
                    j--;
                }
                if (i <= j)
                {
                    double temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < r)
            {
                sort(array, i, r);
            }

            if (l < j)
            {
                sort(array, l, j);
            }
        }
    }
}

