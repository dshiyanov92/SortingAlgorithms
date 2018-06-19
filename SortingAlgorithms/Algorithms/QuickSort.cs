using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Algorithms
{
    class QuickSort : ISort
    {
        public void Sort(int[] array)
        {
            int[] testArray = new int[array.Length];
            Array.Copy(array, testArray, array.Length);

            Quicksort(testArray,0,testArray.Length-1);
        }
        public void Quicksort(int[] numbers, int first, int last)
        {
            int p = numbers[(last - first) / 2 + first];
            int temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (numbers[i] < p && i <= last) ++i;
                while (numbers[j] > p && j >= first) --j;
                if (i <= j)
                {
                    temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) Quicksort(numbers, first, j);
            if (i < last) Quicksort(numbers, i, last);
        }
    }
}
