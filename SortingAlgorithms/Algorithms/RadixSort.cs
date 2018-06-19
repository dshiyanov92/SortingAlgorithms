using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SortingAlgorithms.Algorithms
{
    class RadixSort : ISort
    {
        public void Sort(int[] array)
        {
            int[] testArray = new int[array.Length];
            Array.Copy(array, testArray, array.Length);

            int range = 10;
            int length = 10;

            ArrayList[] lists = new ArrayList[range];
            for (int i = 0; i < range; ++i)
                lists[i] = new ArrayList();

            for (int step = 0; step < length; ++step)
            {
                //распределение по спискам
                for (int i = 0; i < testArray.Length; ++i)
                {
                    int temp = (testArray[i] % (int)Math.Pow(range, step + 1)) /
                                                  (int)Math.Pow(range, step);
                    lists[temp].Add(testArray[i]);
                }
                //сборка
                int k = 0;
                for (int i = 0; i < range; ++i)
                {
                    for (int j = 0; j < lists[i].Count; ++j)
                    {
                        testArray[k++] = (int)lists[i][j];
                    }
                }
                for (int i = 0; i < range; ++i)
                    lists[i].Clear();
            }
        }
    }
}
