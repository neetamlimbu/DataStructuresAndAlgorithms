 # DataStructures And Algorithms in C#

---

## Overview

Data Structures and Algorithms play a key role in determining how our code will perform against Time and Space complexity. 

## Coding Practice Questions using C# and .Net Core

### Strings 

1. How to print duplicate characters in a string? [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Strings/DuplicateCharacters) 
2. How to check if two strings are anagrams of each other? [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Strings/Anagrams)
3. How to reverse String in C# using Iteration and Recursion? [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Strings/ReverseString)
4. How to count number of words in a string? [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Strings/WordCount)
5. How to check if a given string is a Palindrome? [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Strings/Palindrome)
6. How to remove duplicate characters from string? [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Strings/RemoveDuplicateCharacters)
7. How to return highest occurrance of a character in a string? [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Strings/HighestOccurredCharacter)
8. Find all substrings in a string. [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Strings/SubstringInAString)

### Arrays

1. Rotate array to a given pivot (Solution)
2. Determine if any two integers in array sum to given integer (Solution)
3. Sort an array in descending order (Solution)
4. Reverse an array [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Arrays/ReverseArray)
5. Find majority element in an unsorted array (Solution)
6. Merge two sorted arrays into one (Solution)
7. How to find missing number in integer array of 1 to 100?
8. Swap min and max element in integer array (Solution)
9. Move zeros to end of array (Solution)
10. How to check if array contains a duplicate number? (Solution)
11. Linear Search in array [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Arrays/LinearSearch)
12. Binary Search in array [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Arrays/BinarySearch)
13. Aggregate and filter arrays [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Arrays/AggregateAndFilter)

### Numbers

1. How to swap two numbers without using a temp variable? (Solution)
2. How to determine the total ways a stair can be climbed? (Solution) 
3. How to accept 2 integers and return remainder (Solution)
4. How to check if the entered number is Armstrong number? (Solution)
5. How to find GCD and LCM? (Solution)
6. How to check if a number is prime or not? (Solution)
7. How to check if a number is palindromic or not? (Solution)
8. How to solve FizzBuzz problem? (Solution)

### Recursion

1. How to find factorial of a number using recursion? [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/recursion/Factorial)
2. How to find the sum of digits of a number using recursion? (Solution)
3. How to convert a number from Decimal to Binary using recursion? (Solution)
4. How to calculate Power of a number using recursion? (Solution)
5. How to reverse a LinkedList using recursion? (Solution)
6. How to form the Fibonacci series using recursion? (Solution)
7. How to do a recursive binary search in an array? (Solution)
8. How to find GCD using recursion? (Solution)
9. How to print a singly linked list backwards using recursion? (Solution)
10. Towers of Hanoi using recursion? (Solution)
11. How to print nth number in Fibonacci series using recursion? (Solution)

### Linked List

1. Linkedlist Reversal (Solution)
2. Find a node in Linkedlist (Solution)
3. Merge two sorted Linkedlists (Solution)
4. Singly LinkedList Traversal (Solution)
5. Circular Singly Linked List (Solution)
6. Remove duplicates from a sorted Linkedlist (Solution)
7. Find nth to last element in Singly Linkedlist (Solution)
8. Delete nth element from the Head Node (Solution)
9. Detect a cycle in Linkedlist (Solution)

### Stack

1. Stack Implementation (Solution)
2. Stack with Push & Pop operation(Solution)
3. Reverse a Stack (Solution)

### Tree

Trees are non linear data structures and are used in various applications like databases, websites, GUI and so on. They are by definition recursive data structures and constucting them with recursion is far more intuitive.

1. Implement a simple Binary tree [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Trees/BinaryTree)
2. Implement Binary tree using array input [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Trees/ArrayToBinaryTree)

**Building tree using array input**

Input: 10, 20, 30, 40, 50, 60, 70, 80, 90, 100

Desired Output of complete binary tree

                 10                               
              /       \
           20           30
          /   \        /   \
        40     50    60    70
       /  \    /
    80    90  100

A pattern emerges, for a node with index i:

                  0                               
              /       \
            1            2
          /   \        /   \
         3      4     5     6
       /  \    /
     7     8  9

- The left child has index of 2*i + 1   => 1, 3, 5, 7, 9
- The right child has index of 2*i + 2  => 2, 4, 6, 8

With the base case for recursion

`i >= input.length`

3. Implement Binary Search Tree, traverse and search Binary Search Tree [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Trees/BinarySearchTree)
4. Find min and max in Binary search tree [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Trees/BinarySearchTree)
5. Delete nodes from Binary search tree (Solution)
6. Breadth First Search (BFS) (Solution)
7. Depth First Search (DFS) (Solution)

### Graph

1. Breadth First Search (BFS) [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Graphs/BFS)
2. Depth First Search (DFS) [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Graphs/DFS)

### Sorting

1. Selection Sort program [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Sorting/SelectionSort)
2. Insertion Sort program [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Sorting/InsertionSort)
3. Heap Sort program (Solution)
4. Merge Sort program [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Sorting/MergeSort)
5. Quick Sort program [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Sorting/QuickSort)
6. Bubble Sort program [(Solution)](https://github.com/neetamlimbu/DataStructuresAndAlgorithms/tree/master/Sorting/BubbleSort)
7. Shell Sort program (Solution)
8. Comb Sort program (Solution)
9. Bucket Sort program (Solution)
10. Radix Sort program (Solution)

### Misc

1. Bellman–Ford Algorithm (Solution)
2. Floyd–Warshall Algorithm (Solution)
3. Dijkstra Algorithm for Determining the Shortest Path (Solution)
4. Huffman Coding (Solution)
5. Coin change Algorithm : Greedy Algorithm (Solution)
6. Rijndael Algorithm (Solution)
7. Knapsack Problem (Solution)
