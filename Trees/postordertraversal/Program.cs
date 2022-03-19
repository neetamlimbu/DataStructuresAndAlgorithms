using System;
using System.Collections.Generic;

namespace postordertraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Preorder Traversal - LeetCode 145");

            TreeNode root = new TreeNode(1); //[1,null,2,3]
            root.right = new TreeNode(2);
            root.right.left = new TreeNode(3);

            IList<int> list = PostorderTraversal(root);
            Console.Write("[ ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.Write("]");
            Console.WriteLine();

            list = PostorderTraversal(null);
            Console.Write("[ ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.Write("]");
            Console.WriteLine();
        }

        static IList<int> PostorderTraversal(TreeNode root)
        {
            return PostorderTraversal(root, new List<int>());
        }

        static IList<int> PostorderTraversal(TreeNode treeNode, IList<int> list)
        {
            if (treeNode == null)
                return list;

            PostorderTraversal(treeNode.left, list);
            PostorderTraversal(treeNode.right, list);
            list.Add(treeNode.value);

            return list;
        }


    }
}
