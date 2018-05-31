using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    class Program
    {
        enum Cases {Best, Average};
        static void Main(string[] args)
        {
            ArrayGenerator sort = new ArrayGenerator();
            int size = 100;
            int[] testArray = sort.GenerateArray(size);
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            
            // Сортировка выбором           
            sw.Start();
            ArraySort.SelectionSort(testArray);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            //Сортировка вставками
            testArray = sort.GenerateArray(size);
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ArraySort.InsertionSort(testArray);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            
            //Сортировка Шелла
            testArray = sort.GenerateArray(size);
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ArraySort.ShellSort(testArray);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            //Быстрая сортировка
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ArraySort.Quicksort(testArray,0,testArray.Length-1);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            //Сортировка слиянием
            testArray = sort.GenerateArray(size);
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ArraySort.MergeSort(ref testArray,0,testArray.Length-1);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            //Поразрядная сортировка
            testArray = sort.GenerateArray(size);
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ArraySort.RadixSort(testArray,10,10);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
