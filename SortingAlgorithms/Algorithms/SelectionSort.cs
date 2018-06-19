using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Algorithms
{
    public class SelectionSort : ISort
    {
        public void Sort(int[] array)
        {
            int[] testArray = new int[array.Length];
            Array.Copy(array, testArray, array.Length);

            for (int i = 0; i < testArray.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < testArray.Length; j++)
                {
                    if (testArray[j] < testArray[min])
                    {
                        min = j;
                    }
                }
                int temp = testArray[i];
                testArray[i] = testArray[min];
                testArray[min] = temp;
            }
        }
    }
}