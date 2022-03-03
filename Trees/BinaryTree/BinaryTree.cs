using System;

namespace BinaryTree
{
    public class BinaryTree
    {
        public TreeNode root;

        public BinaryTree(int value)
        {
            root = new TreeNode(value);
        }

        public void PreOrderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Console.Write(root.data + " ");
            PreOrderTraversal(root.left);
            PreOrderTraversal(root.right);
        }

        public void InOrderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            InOrderTraversal(root.left);
            Console.Write(root.data + " ");
            InOrderTraversal(root.right);
        }

        public void PostOrderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            PostOrderTraversal(root.left);
            PostOrderTraversal(root.right);
            Console.Write(root.data + " ");
        }
    }
}