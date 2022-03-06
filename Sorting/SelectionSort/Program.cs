using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selection Sort...");

            int[] arr = { 7, 4, 10, 8, 3, 1 };
            SelectionSort(arr);

            Array.ForEach(arr, element => Console.Write(element + " "));
        }

        static void SelectionSort(int[] input)
        {
            //Divide the array into sorted sub array to the left and unsorted sub array to the right
            //Initially, the first element is considered to be in sorted list and the rest of the elements to be in unsorted list
            //Find the minimum element and swap with the element in start index of unsorted sub array
            //In this case 1 is swapped with 7
            //In the second iteration, 4 is swapped with 3 and so on

            for (int i = 0; i < input.Length - 1; i++)
            {
                int min = i;
                //Loop through all the elements in unsorted sub array
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[j] < input[min])
                    {
                        min = j; //Update the index with the element containing minimum value
                    }
                }

                if (min != i)
                {
                    //Swap
                    int temp = input[min];
                    input[min] = input[i];
                    input[i] = temp;
                }
            }
        }
    }
}
