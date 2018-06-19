using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Algorithms
{
    class InsertionSort : ISort
    {
        public void Sort(int[] array)
        {
            int[] testArray = new int[array.Length];
            Array.Copy(array, testArray, array.Length);

            int newElement, location;
            for (int i = 1; i < testArray.Length; i++)
            {
                newElement = testArray[i];
                location = i - 1;
                while (location >= 0 && testArray[location] > newElement)
                {
                    testArray[location + 1] = testArray[location];
                    location = location - 1;
                }
                testArray[location + 1] = newElement;
            }
        }
    }
}
