using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class ArrayGenerator
    {
        
      public int[] GenerateArray(int size)
        {
            switch (size){

            }
            Random n = new Random();
            int[] array = new int[size];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = n.Next(0, 2000000000);
            }
            return array;
        }


    }
}
