using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MergeSort...");

            int[] arr = { 15, 5, 24, 8, 1, 3, 16, 10, 20 };
            MergeSort(arr, 0, arr.Length -1);
            Array.ForEach(arr, element => Console.Write(element + " "));
        }

        static void MergeSort(int[] input, int lowerBound, int upperBound)
        {
            if (lowerBound < upperBound)
            {
                int mid = (lowerBound + upperBound) / 2;

                //Recursively call sort so that the array is divided into individual elements
                //[15] [5] [24] [8] [1] [3] [16] [10] [20]
                MergeSort(input, lowerBound, mid);
                MergeSort(input, mid + 1, upperBound);

                //Recursively merge the array into new array by comparing each element in the divided lists
                Merge(input, lowerBound, mid, upperBound);
            }
        }


        static void Merge(int[] input, int lowerBound, int mid, int upperBound)
        {
            int i = lowerBound; //Index to first array sublist 
            int j = mid + 1;    //Index to second array sublist
            int k = lowerBound; //Index of new array to hold merged array list

            //Array to hold the sorted list
            int[] temp = new int[input.Length];
            Array.Copy(input, temp, input.Length);

            //Loop through all the elements in both array sublists and compare
            //The smaller element is added to new merge array list
            while (i <= mid && j <= upperBound)
            {
                if (temp[i] <= temp[j])
                {
                    input[k] = temp[i];
                    i++;
                }
                else
                {
                    input[k] = temp[j];
                    j++;
                }

                k++; //Increment the index for the new array list
            }

            //After comparing and merging both sublists, we might have some elements left in the left or right sublist
            //Loop through all the elements if any in the sublist and add them to the new merged array list
            if (i > mid)
            {
                while (j <= upperBound)
                {
                    input[k] = temp[j];
                    j++;
                    k++;
                }
            }
            else if (j > upperBound)
            {
                while (i <= mid)
                {
                    input[k] = temp[i];
                    i++;
                    k++;
                }
            }
        }
    }
}
