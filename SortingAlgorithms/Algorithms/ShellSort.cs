using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Algorithms
{
    class ShellSort : ISort
    {
        public void Sort(int[] array)
        {
            int[] testArray = new int[array.Length];
            Array.Copy(array, testArray, array.Length);

            int step = testArray.Length / 2;
            while (step > 0)
            {
                int i, j;
                for (i = step; i < testArray.Length; i++)
                {
                    int value = testArray[i];
                    for (j = i - step; (j >= 0) && (testArray[j] > value); j -= step)
                        testArray[j + step] = testArray[j];
                    testArray[j + step] = value;
                }
                step /= 2;
            }
        }
    }
}
