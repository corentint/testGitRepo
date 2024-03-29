﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_exercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 23, 2, 3, 34, 6, 1, 24, 45, 78, 8 }; //unsorted data set
            bubblesort(arr, 10); //sorting process using bubble sort
            int i;
            for (i = 0; i < 10; i++)
                Console.Write(arr[i] + "\t"); //after sorting in ascending order

            Console.ReadLine();

        }
        ///bubble sort

        static public void bubblesort(int[] dataset, int n)
        {
            int i, j;
            for (i = 0; i < n; i++)
                for (j = n - 1; j > i; j--)
                    if (dataset[j] < dataset[j - 1])
                    {
                        int temp = dataset[j];
                        dataset[j] = dataset[j - 1];
                        dataset[j - 1] = temp;
                    }

        }
    }
}
