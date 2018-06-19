using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Algorithms
{
    class QuickSort : ISort
    {
        public void Sort(int[] array)
        {
            int first = 0;
            int last = array.Length - 1;
            int p = array[(last - first) / 2 + first];
            int temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (array[i] < p && i <= last) ++i;
                while (array[j] > p && j >= first) --j;
                if (i <= j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    ++i; --j;
                }
            }
           // if (j > first) Sort(array, first, j);
           // if (i < last) Sort(array, i, last);
        }
    }
}
