using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppInsertionSort
{
    internal class Program
    {
        public static void InsertionSort(int[] arr)
        {
            int n =arr.Length;
            for(int i = 0; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key) 
                {
                    arr[j+1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        public static void Print(int[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = { 7, 4, 5, 2, 6, 78, 43, 22 };
            Console.WriteLine("Array without doing insertion sort");
            Print(arr);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            InsertionSort(arr);
            stopWatch.Stop();
            Console.WriteLine("Array after insertion sort");
            Print(arr);
            Console.WriteLine($"Array Size = {arr.Length} \t Time Taken = {stopWatch.Elapsed.TotalMilliseconds} milliseconds");
            Console.ReadKey();
        }
    }
}
