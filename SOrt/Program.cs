using System;
using System.Collections.Generic;
using System.IO;

namespace Sort
{
    internal class Program
    {
        private static void Main(string[] args) { 
            short[] a = new short[] { 1, 5, 3, 2, 7, 3 };
            short[] g = Sorting.QuickSort(a);
            short[] o = Sorting.QuickSort(a,true);
            short[] l = Sorting.BubbleSort(a);
            Console.ReadKey();
        }
    }
}