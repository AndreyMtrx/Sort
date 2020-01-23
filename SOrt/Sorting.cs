using System;

namespace Sort
{
    public static class Sorting
    {
        /// <summary>
        /// Checks if an array is sorted in ascending order
        /// </summary>
        /// <param name="array">Array to check</param>
        /// <returns>true - array is sorted ascending, false - array is not sorted ascending</returns>
        public static bool IsSortedAscending<T>(T[] array) where T : IComparable<T>, IComparable
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].CompareTo(array[i + 1]) >= 0)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if an array is sorted in descending order
        /// </summary>
        /// <param name="array">Array to check</param>
        /// <returns>true - array is sorted descending, false - array is not sorted descending</returns>
        public static bool IsSortedDescending<T>(T[] array) where T : IComparable<T>, IComparable
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].CompareTo(array[i + 1]) <= 0)
                    return false;
            }
            return true;
        }

        private static void Swap<T>(ref T n1, ref T n2)
        {
            var temp = n1;
            n1 = n2;
            n2 = temp;
        }

        /// <summary>
        /// Sorts an array using the bubble method
        /// </summary>
        /// <param name="array">Array to sort</param>
        /// <param name="desc">true - descending sort</param>
        /// <returns>Sorted array</returns>
        public static T[] BubbleSort<T>(T[] array, bool desc = false) where T : IComparable<T>, IComparable
        {
            if (!desc)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i].CompareTo(array[j]) > 0)
                        {
                            Swap(ref array[i], ref array[j]);
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i].CompareTo(array[j]) < 0)
                        {
                            Swap(ref array[i], ref array[j]);
                        }
                    }
                }
            }
            return array;
        }
        /// <summary>
        /// Sorts an array using the quicksort method
        /// </summary>
        /// <param name="array">Array to sort</param>
        /// <param name="desc">true - descending sort</param>
        /// <returns>Sorted array</returns>
        public static T[] QuickSort<T>(T[] array, bool desc = false) where T : IComparable<T>, IComparable
        {
            return QuickSort(array, 0, array.Length - 1, desc);
        }

        private static T[] QuickSort<T>(T[] array, int minIndex, int maxIndex, bool desc) where T : IComparable<T>, IComparable
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            int pivotIndex = Partition(array, minIndex, maxIndex, desc);
            QuickSort(array, minIndex, pivotIndex - 1, desc);
            QuickSort(array, pivotIndex + 1, maxIndex, desc);

            return array;
        }

        private static int Partition<T>(T[] array, int minIndex, int maxIndex, bool desc) where T : IComparable<T>, IComparable
        {
            var pivot = minIndex - 1;
            if (!desc)
            {
                for (var i = minIndex; i < maxIndex; i++)
                {
                    if (array[i].CompareTo(array[maxIndex]) < 0)
                    {
                        pivot++;
                        Swap(ref array[pivot], ref array[i]);
                    }
                }
            }
            else
            {
                for (var i = minIndex; i < maxIndex; i++)
                {
                    if (array[i].CompareTo(array[maxIndex]) > 0)
                    {
                        pivot++;
                        Swap(ref array[pivot], ref array[i]);
                    }
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }
    }
}