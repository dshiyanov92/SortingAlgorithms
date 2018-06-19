using System;
using System.IO;
using System.Collections.Generic;
using SortingAlgorithms.Algorithms;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraySize = { 100, 500, 1000, 5000, 10000, 50000, 100000 };
            ArrayGenerator.Cases[] cases = { ArrayGenerator.Cases.Random, ArrayGenerator.Cases.Best };
            ArrayGenerator sort = new ArrayGenerator();

            for (int j = 0; j < cases.Length; j++)
            {
                for (int i = 0; i < arraySize.Length; i++)
                {
                    int[] testArray = sort.GenerateArray(arraySize[i], cases[j]);

                    BaseSort context = new BaseSort(new InsertionSort());
                    context.ExecuteSort(testArray);

                    context.SetSortAlgorithm(new SelectionSort());
                    context.ExecuteSort(testArray);

                    context.SetSortAlgorithm(new MergeSort());
                    context.ExecuteSort(testArray);

                    context.SetSortAlgorithm(new ShellSort());
                    context.ExecuteSort(testArray);

                    context.SetSortAlgorithm(new RadixSort());
                    context.ExecuteSort(testArray);
                }
            }
        }
    }
}
