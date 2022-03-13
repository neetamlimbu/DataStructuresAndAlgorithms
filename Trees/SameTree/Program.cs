using System;

namespace SameTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Same Tree - Leetcode 100");

            TreeNode p = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            TreeNode q = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            Console.WriteLine(IsSameTree(p, q));

            p = new TreeNode(1, new TreeNode(2));
            q = new TreeNode(1, null, new TreeNode(2));
            Console.WriteLine(IsSameTree(p, q));

            p = new TreeNode(1, new TreeNode(2), new TreeNode(1));
            q = new TreeNode(1, new TreeNode(1), new TreeNode(2));
            Console.WriteLine(IsSameTree(p, q));
        }

        /*Definition for a binary tree node */
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

        static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null || q == null)
                return p == q;

            if (p.val != q.val)
                return false;

            if (!IsSameTree(p.left, q.left))
                return false;

            if (!IsSameTree(p.right, q.right))
                return false;

            return true;
        }
    }
}
