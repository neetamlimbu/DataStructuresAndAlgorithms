using System;

namespace BalancedBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Balanced Binary Tree - Leetcode 110");

            //[1, 2, 2, 3, 3, null, null, 4, 4]
            TreeNode root = new TreeNode(1, new TreeNode(2), new TreeNode(2));

            TreeNode left = root.left;
            left.left = new TreeNode(3);
            left.right = new TreeNode(3);
            left.left.left = new TreeNode(4);
            left.left.right = new TreeNode(4);

            Console.WriteLine(IsBalanced(root));
        }

        /* Definition for a binary tree node */
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        static bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;

            if (Math.Abs(GetHeight(root.left) - GetHeight(root.right)) > 0)
            {
                return false;
            }

            return IsBalanced(root.left) && IsBalanced(root.right);
        }

        static int GetHeight(TreeNode treeNode)
        {
            if (treeNode == null)
                return 0;

            return Math.Max(GetHeight(treeNode.left), GetHeight(treeNode.right)) + 1;
        }
    }
}
