using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insertion Sort...");
            int[] arr = { 5, 4, 10, 1, 6, 2 };
            InsertionSort(arr);
            Array.ForEach(arr, element => Console.Write(element + " "));
        }

        public static void InsertionSort(int[] input)
        {
            //Divide array into sorted and unsorted sub array lists
            //Initially, the first element is chosen as the left sorted sub array list 
            //For example - 
            //Sorted List | Unsorted List
            //          5 | 4 10 1 6 2
            
            //The element in the second index is stored in the temp variable for comparison
            //Initially,  temp = 4
            //Pick elements one by one from the unsorted list and compare with the elements in the sorted list
            //Check if the element of the sorted list is greater than the element being compared from the unsorted list
            //Move the element in the sorted list to higher index

            for (int i = 1; i < input.Length; i++)
            {
                int temp = input[i];
                int j = i - 1;

                while (j >= 0 && input[j] > temp)
                {
                    input[j + 1] = input[j]; //Shift greater element to higher index
                    j--;
                }

                input[j + 1] = temp;
            }
        }
    }
}
