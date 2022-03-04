using System;

namespace ArrayToBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary tree using array input...");

            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            BinaryTree binaryTree = new BinaryTree(arr);
            TreeNode root = binaryTree.root;
            Console.WriteLine("In Order Traversal");
            binaryTree.DisplayInOrderTraversal();
            Console.WriteLine();
            Console.WriteLine("Pre Order Traversal");
            binaryTree.DisplayPreOrderTraversal();
            Console.WriteLine();
            Console.WriteLine("Post Order Traversal");
            binaryTree.DisplayPostOrderTraversal();
        }
    }
}
