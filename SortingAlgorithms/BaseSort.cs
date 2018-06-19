using SortingAlgorithms.Algorithms;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SortingAlgorithms
{
    class BaseSort
    {
        private ISort _sort;
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        string fileName = String.Concat(@"C:\Users\N56\Desktop\SortingAlgorithms\Review.txt");


        public BaseSort(ISort sort)
        {
            _sort = sort;
        }
        public void SetSortAlgorithm(ISort sort)
        {
            _sort = sort;
        }
        public void ExecuteSort(int[] array)
        {
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            _sort.Sort(array);
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalMilliseconds);
            File.AppendAllText(fileName, _sort.ToString() + Environment.NewLine);
            File.AppendAllText(fileName, "Array length - " + array.Length.ToString() + Environment.NewLine);
            File.AppendAllText(fileName, "Sorting time, ms - " + sw.Elapsed.TotalMilliseconds.ToString() + Environment.NewLine + Environment.NewLine);

        }
    }
}
