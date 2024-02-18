using System;

namespace Algorithms.Algorithms
{
    public static class Sorting
    {
        /// <summary>
        /// Method <c>InsertionSort</c> sorts an array of integers.
        /// The array is divided in two parts: a sorted part, consisting of the first
        /// element of the array, and an unsorted part, consisting of the rest of the array.
        /// The next element from the unsorted part of the array is taken and inserted
        /// in the correct position in the sorted part of the array.
        /// This is an efficient algorithm for sorting a small number of elements.
        /// </summary>
        /// <param name="array">An array of integers.</param>
        /// <returns>The sorted array.</returns>
        public static int[] InsertionSort(int[] array)
        {
            if (array == null) throw new ArgumentNullException("array");

            if (array.Length < 1) return array;

            int key;
            int j;
            for (int i = 1; i < array.Length; i++)
            {
                key = array[i];
                j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j+1] = array[j];
                    j--;
                }

                array[j+1] = key;
            }

            return array;
        }
    }
} 
