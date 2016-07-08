namespace Calc_IVT_152_DB.SortArray
{
    public class BubbleSort : ISortArray
    {
        /// <summary>
        /// sorts array by bubble method
        /// </summary>
        /// <param name="array">
        /// pointer to double array
        /// </param>
        public void SortArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        double temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
