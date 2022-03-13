using System;

namespace SymmetricTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Symmetric Tree - Leetcode 101");

            TreeNode root = new TreeNode(1, new TreeNode(0), null); //[1,0]
            Console.WriteLine(IsSymmetric(root));

            root = new TreeNode(1, new TreeNode(2), new TreeNode(2)); //[1,2,2,3,4,4,3]
            TreeNode left = root.left;
            TreeNode right = root.right;
            left.left = new TreeNode(3);
            left.right = new TreeNode(4);
            right.left = new TreeNode(4);
            right.right = new TreeNode(3);
            Console.WriteLine(IsSymmetric(root));

            root = new TreeNode(1, new TreeNode(2), new TreeNode(2)); //[1,2,2,null,3,null,3]
            left = root.left;
            right = root.right;
            left.left = null;
            left.right = new TreeNode(3);
            right.left = null;
            right.right = new TreeNode(3);
            Console.WriteLine(IsSymmetric(root));
        }

        /* Definition for a binary tree node. */

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

        static bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;

            return IsSymmetric(root.left, root.right);
        }

        static bool IsSymmetric(TreeNode left, TreeNode right)
        {
            if (left == null || right == null)
                return left == right;

            if (left.val != right.val)
                return false;

            if (!IsSymmetric(left.left, right.right))
                return false;

            if (!IsSymmetric(left.right, right.left))
                return false;

            return true;
        }
    }
}
