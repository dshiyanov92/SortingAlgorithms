using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Algorithms
{
    class MergeSort : ISort
    {
        public void Sort(int[] array)
        {
            int[] testArray = new int[array.Length];
            Array.Copy(array, testArray, array.Length);

            MergeSort_Recursive(testArray, 0, testArray.Length - 1);

        }
        void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[numbers.Length];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        void MergeSort_Recursive(int[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort_Recursive(numbers, left, mid);
                MergeSort_Recursive(numbers, (mid + 1), right);

                DoMerge(numbers, left, (mid + 1), right);
            }
        }
    }
}
