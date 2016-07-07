using System;

namespace Calc_IVT_152_DB.SortArray
{
    public static class SortArrayFactory
    {
        public static ISortArray Create(string SortType)
        {
            switch (SortType)
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
