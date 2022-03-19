using System;

namespace SortedArrayToBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorted Array to Binary Search Tree...");

            int[] arr = { 3, 9, 20, 15, 7 };
            PreOrderTraversal(SortedArrayToBST(arr, 0, arr.Length - 1));
        }

        static void PreOrderTraversal(TreeNode treeNode)
        {
            Console.Write(treeNode.val + " ");
            if (treeNode.left != null)
                PreOrderTraversal(treeNode.left);

            if (treeNode.right != null)
                PreOrderTraversal(treeNode.right);
        }


        static TreeNode SortedArrayToBST(int[] input, int start, int end)
        {
            if (start > end)
                return null;

            int mid = (start + end) / 2;

            TreeNode treeNode = new TreeNode(input[mid]);
            treeNode.left = SortedArrayToBST(input, start, mid - 1);
            treeNode.right = SortedArrayToBST(input, mid + 1, end);

            return treeNode;
        }
    }
}
