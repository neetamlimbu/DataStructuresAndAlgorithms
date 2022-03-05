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
            int pivot = input[lowerBound]; //Pivot element to comapre with, in this case input[0] that is 7
            int start = lowerBound;        //Pointer to the start of the left sub array
            int end = upperBound;          //Pointer to the end of the right sub array

            while (start < end)  //Repeat the process of swapping until the left sub array pointer is greater than or equal to right sub array pointer
            {
                while (start <= input.Length - 1 && input[start] <= pivot)
                {
                    start++; //Increment left pointer until the pivot element is less that the element at index "input[start]"
                }
                while (end >= 0 && input[end] > pivot)
                {
                    end--; //Decrement right pointer until the pivot element is greater than the element at index "input[end]"
                }
                //Swap only when the left pointer is less than end pointer
                //Because the left sub array is less than the pivot element and the right sub array is greater than the pivot element
                //Swap greater elements to the right and lesser elements to the left
                if (start < end)
                {
                    Swap(input, start, end);
                }
            }

            //If left sub array pointer is greater than right sub array pointer, then it means more elements less than pivot element exists in right sub array
            //So in this case, pivot element is swapped with lesser element at index of right sub array pointer
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
