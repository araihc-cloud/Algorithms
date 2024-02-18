using System;
using System.IO;

namespace Algorithms
{
    internal class Program
    {
        private static void SelectSortingAlgorithm()
        {
            Console.WriteLine("Select a sorting algorithm:");
            Console.WriteLine("1 -> Insertion sort");

            string algorithm = Console.ReadLine();
            switch (algorithm)
            {
                case "1":
                    break;
                default:
                    throw new InvalidDataException("The selected algorithm is not valid.");
            }
        }

        private static void SelectOperation()
        {
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1 -> Sorting");

            string operation = Console.ReadLine();
            switch (operation)
            {
                case "1":
                    Console.WriteLine("You have selected Sorting.");
                    SelectSortingAlgorithm();
                    break;
                default:
                    throw new InvalidDataException("The selected operation is not valid.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            SelectOperation();
        }
    }
}
