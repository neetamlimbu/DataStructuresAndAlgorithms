using System;
using System.Collections.Generic;

namespace PreOrderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Preorder Traversal - LeetCode 144");

            TreeNode root = new TreeNode(1); //[1,null,2,3]
            root.right = new TreeNode(2);
            root.right.left = new TreeNode(3);

            IList<int> list = PreorderTraversal(root);
            Console.Write("[");
            foreach(int i in list)
            {
                Console.Write(i + " ");
            }
            Console.Write("]");
            Console.WriteLine();

            list = PreorderTraversal(null);
            Console.Write("[");
            foreach(int i in list)
            {
                Console.Write(i + " ");
            }
            Console.Write("]");
            Console.WriteLine();
        }

        static IList<int> PreorderTraversal(TreeNode root)
        {
            return PreorderTraversal(root, new List<int>());
        }

        static IList<int> PreorderTraversal(TreeNode treeNode, IList<int> list)
        {
            if(treeNode == null)
                return list;

            list.Add(treeNode.value);
            PreorderTraversal(treeNode.left, list);
            PreorderTraversal(treeNode.right, list);
            
            return list;
        }
    }
}
