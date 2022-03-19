using System;

namespace MinimumDepth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minimum Depth - LeetCode 111");

            TreeNode root = new TreeNode(3); //[3,9,20,null,null,15,7]
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            Console.WriteLine(MinimumDepth(root));

            root = new TreeNode(2); //[2,null,3,null,4,null,5,null,6]
            root.right = new TreeNode(3);
            root.right.right = new TreeNode(4);
            root.right.right.right = new TreeNode(5);
            root.right.right.right.right = new TreeNode(6);
            Console.WriteLine(MinimumDepth(root));
        }

        static int MinimumDepth(TreeNode treeNode)
        {
            if (treeNode == null)
                return 0;

            if (treeNode.left == null)
                return MinimumDepth(treeNode.right) + 1;

            if (treeNode.right == null)
                return MinimumDepth(treeNode.left) + 1;

            return Math.Min(MinimumDepth(treeNode.left), MinimumDepth(treeNode.right)) + 1;
        }
    }
}
