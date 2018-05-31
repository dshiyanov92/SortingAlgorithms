using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Лучший случай - Отсортированный массив");
            Console.WriteLine("---------------------------");

            ArrayGenerator sort = new ArrayGenerator();
            int size = 100000;
            int[] testArray = sort.GenerateArray(size,ArrayGenerator.Cases.Best);
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            // Selection sort            
            sw.Start();
            ArraySort.SelectionSort(testArray);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            // Insertion sort
            testArray = sort.GenerateArray(size, ArrayGenerator.Cases.Best);           
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ArraySort.InsertionSort(testArray);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            // Shellsort
            testArray = sort.GenerateArray(size, ArrayGenerator.Cases.Best);
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ArraySort.ShellSort(testArray);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            // Quicksort
            testArray = sort.GenerateArray(size, ArrayGenerator.Cases.Best);
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ArraySort.Quicksort(testArray,0,testArray.Length-1);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            // Merge sort
            testArray = sort.GenerateArray(size, ArrayGenerator.Cases.Best);
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ArraySort.MergeSort(ref testArray,0,testArray.Length-1);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            // RadixSort
            testArray = sort.GenerateArray(size, ArrayGenerator.Cases.Best);
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ArraySort.RadixSort(testArray,10,10);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            Console.WriteLine("---------------------------");
            Console.WriteLine("Лучший случай - Частично отсортированный массив");
            Console.WriteLine("---------------------------");


            // Selection sort   
            testArray = sort.GenerateArray(size, ArrayGenerator.Cases.Average);
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ArraySort.SelectionSort(testArray);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            // Insertion sort
            testArray = sort.GenerateArray(size, ArrayGenerator.Cases.Average);
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ArraySort.InsertionSort(testArray);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            // Shellsort
            testArray = sort.GenerateArray(size, ArrayGenerator.Cases.Average);
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ArraySort.ShellSort(testArray);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            // Quicksort
            testArray = sort.GenerateArray(size, ArrayGenerator.Cases.Average);
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ArraySort.Quicksort(testArray, 0, testArray.Length - 1);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            // Merge sort
            testArray = sort.GenerateArray(size, ArrayGenerator.Cases.Average);
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ArraySort.MergeSort(ref testArray, 0, testArray.Length - 1);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            // RadixSort
            testArray = sort.GenerateArray(size, ArrayGenerator.Cases.Average);
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ArraySort.RadixSort(testArray, 10, 10);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            Console.WriteLine("---------------------------");
            Console.WriteLine("Худший случай");
            Console.WriteLine("---------------------------");

            // Selection sort   
            testArray = sort.GenerateArray(size, ArrayGenerator.Cases.Worst);
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ArraySort.SelectionSort(testArray);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            // Insertion sort
            testArray = sort.GenerateArray(size, ArrayGenerator.Cases.Worst);
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ArraySort.InsertionSort(testArray);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            // Shellsort
            testArray = sort.GenerateArray(size, ArrayGenerator.Cases.Worst);
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ArraySort.ShellSort(testArray);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            // Quicksort
            testArray = sort.GenerateArray(size, ArrayGenerator.Cases.Worst);
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ArraySort.Quicksort(testArray, 0, testArray.Length - 1);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            // Merge sort
            testArray = sort.GenerateArray(size, ArrayGenerator.Cases.Worst);
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ArraySort.MergeSort(ref testArray, 0, testArray.Length - 1);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            // RadixSort
            testArray = sort.GenerateArray(size, ArrayGenerator.Cases.Worst);
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ArraySort.RadixSort(testArray, 10, 10);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
