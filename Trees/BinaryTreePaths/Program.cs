using System;
using System.Collections.Generic;

namespace BinaryTreePaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree Paths - LeetCode 257");

            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.right = new TreeNode(5);

            foreach (string path in BinaryTreePaths(root))
            {
                Console.WriteLine(path);
            }
        }

        static IList<string> BinaryTreePaths(TreeNode root)
        {
            List<string> paths = new List<string>();

            if (root == null)
                return paths;

            return BinaryTreePaths(root, "", paths);
        }

        static IList<string> BinaryTreePaths(TreeNode treeNode, string path, IList<string> paths)
        {
            if (treeNode == null)
                return paths;

            path += treeNode.value;

            if(treeNode.left == null && treeNode.right == null)
            {
                paths.Add(path);
                return paths;
            }

            if (treeNode.left != null)
                BinaryTreePaths(treeNode.left, path + "->", paths);

            if (treeNode.right != null)
                BinaryTreePaths(treeNode.right, path + "->", paths);

            return paths;
        }
    }
}
