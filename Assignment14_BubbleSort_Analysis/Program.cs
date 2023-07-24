using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14_BubbleSort_Analysis
{
    internal class Program
    {
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped) 
                { break; }
            }
        }
        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for(int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j]< arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }
        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for( int i = 0; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j+1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
        static int[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            int[] arr = new int[size];
            for(int i = 0; i < size; i++)
            {
                arr[i] = random.Next(1, 1000);
            }
            return arr;
        }
        static bool IsSorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] arraySizes = { 100, 500, 5000, 10000 };
            foreach(int size in  arraySizes)
            {
                int[] randomArray = GenerateRandomArray(size);
                int[] bubbleSortedArray = (int[])randomArray.Clone();
                int[] selectionSortedArray = (int[])randomArray.Clone();
                int[] insertionSortedArray = (int[])randomArray.Clone();

                Console.WriteLine($"Sorting {size} elements with bubble sort");
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                BubbleSort(bubbleSortedArray);
                stopwatch.Stop();
                Console.WriteLine($"Bubble Sort took {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
                if(IsSorted(bubbleSortedArray))
                { Console.WriteLine("Array sorted corrctly"); }
                else
                {
                    Console.WriteLine("Array sorted incorrectly");
                }
                Console.WriteLine($"Sorting {size} elements with selection sort");
                Stopwatch stopwatch1 = new Stopwatch();
                stopwatch1.Start();
                SelectionSort(selectionSortedArray);
                stopwatch1.Stop();
                Console.WriteLine($"Selection Sort took {stopwatch1.Elapsed.TotalMilliseconds} milliseconds");
                if (IsSorted(selectionSortedArray))
                { Console.WriteLine("Array sorted corrctly"); }
                else
                {
                    Console.WriteLine("Array sorted incorrectly");
                }
                Console.WriteLine($"Sorting {size} elements with insertion sort");
                Stopwatch stopwatch2 = new Stopwatch();
                stopwatch2.Start();
                InsertionSort(insertionSortedArray);
                stopwatch2.Stop();
                Console.WriteLine($"Insertion Sort took {stopwatch2.Elapsed.TotalMilliseconds} milliseconds");
                if (IsSorted(insertionSortedArray))
                { Console.WriteLine("Array sorted correctly"); }
                else
                {
                    Console.WriteLine("Array sorted incorrectly");
                }
                Console.ReadKey();
            }
        }
    }
}
