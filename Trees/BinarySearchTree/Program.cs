using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree...");

            int[] arr = { 20, 10, 30, 6, 21, 3, 8, 4};

            BinarySearchTree binarySearchTree = new BinarySearchTree();
            TreeNode root =  binarySearchTree.BuildBinarySearchTree(arr, 0);

            Console.WriteLine("PreOrder Traversal");
            binarySearchTree.PreOrderTraversal();
            Console.WriteLine();
            Console.WriteLine("InOrder Traversal");
            binarySearchTree.InOrderTraversal();
            Console.WriteLine();
            Console.WriteLine("PostOrder Traversal");
            binarySearchTree.PostOrderTraversal();
            Console.WriteLine();
            binarySearchTree.Search(8);
            binarySearchTree.Search(15);
            Console.WriteLine("Min Value is {0}", binarySearchTree.FindMin()); 
            Console.WriteLine("Max Value is {0}", binarySearchTree.FindMax()); 
        }
    }
}
