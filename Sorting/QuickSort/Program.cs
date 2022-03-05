using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QuickSort...");

            int[] arr = { 7, 6, 10, 5, 9, 2, 1, 15, 7 };

            QuickSort(arr, 0, arr.Length - 1);
            Array.ForEach(arr, element => Console.Write(element + " "));
        }

        static public int Partition(int[] input, int lowerBound, int upperBound)
        {
            int pivot = input[lowerBound];
            int start = lowerBound;
            int end = upperBound;

            while (start < end)
            {
                while (start <= input.Length - 1 && input[start] <= pivot)
                {
                    start++;
                }
                while (end >= 0 && input[end] > pivot)
                {
                    end--;
                }
                if (start < end)
                {
                    Swap(input, start, end);
                }
            }

            Swap(input, end, lowerBound);

            return end;
        }

        static public void QuickSort(int[] arr, int lowerBound, int upperBound)
        {
            if (lowerBound < upperBound)
            {
                int pivot = Partition(arr, lowerBound, upperBound);
                QuickSort(arr, lowerBound, pivot - 1);
                QuickSort(arr, pivot + 1, upperBound);
            }
        }

        static void Swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index2];
            arr[index2] = arr[index1];
            arr[index1] = temp;
        }
    }
}
