using System;

namespace Calc_IVT_152_DB.SortArray
{
    public static class SortArrayFactory
    {
        /// <summary>
        /// Creates calculator of sorting function by name
        /// </summary>
        /// <param name="calcName">
        /// Name of sort
        /// </param>
        /// <returns>
        /// object of sorting function
        /// </returns>
        public static ISortArray Create(string sortType)
        {
            switch (sortType)
            {
                case "buttonBubble":
                    return new BubbleSort();
                case "buttonQuick":
                    return new QuickSort();
                default:
                    throw new Exception("Неизвестный метод сортировки");
            }
        }
    }
}
