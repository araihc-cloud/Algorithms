using Algorithms.Algorithms;
using System;
using System.IO;

namespace Algorithms
{
    internal class Program
    {
        private static int[] array = { 99, 11, 22, 66, 55, 33, 44, 88, 77 };

        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        private static void SelectSortingAlgorithm()
        {
            Console.WriteLine("Select a sorting algorithm:");
            Console.WriteLine("1 -> Insertion sort\n");

            string algorithm = Console.ReadLine();
            switch (algorithm)
            {
                case "1":
                    Console.WriteLine("You have selected insertion sort.\n");
                    Console.WriteLine("Given an unsorted array:");
                    PrintArray(array);
                    Console.WriteLine("After insertion sort is performed:");
                    PrintArray(Sorting.InsertionSort(array));
                    break;
                default:
                    throw new InvalidDataException("The selected algorithm is not valid.");
            }
        }

        private static void SelectOperation()
        {
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1 -> Sorting\n");

            string operation = Console.ReadLine();
            switch (operation)
            {
                case "1":
                    Console.WriteLine("You have selected Sorting.\n");
                    SelectSortingAlgorithm();
                    break;
                default:
                    throw new InvalidDataException("The selected operation is not valid.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!\n");
            SelectOperation();
        }
    }
}
