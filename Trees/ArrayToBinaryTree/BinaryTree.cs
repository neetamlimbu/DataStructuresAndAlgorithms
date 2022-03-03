using System;

namespace ArrayToBinaryTree
{
    public class BinaryTree
    {
        public TreeNode root;

        public BinaryTree(int[] input)
        {
            root = BuildBinaryTree(input, 0);
        }

        private TreeNode BuildBinaryTree(int[] input, int i)
        {
            if (i >= input.Length)
                return null;

            TreeNode nextTreeNode = new TreeNode(input[i]);

            nextTreeNode.left = BuildBinaryTree(input, 2 * i + 1);
            nextTreeNode.right = BuildBinaryTree(input, 2 * i + 2);

            return nextTreeNode;
        }

        public void DisplayInOrderTraversal(TreeNode root)
        {
            if (root == null)
                return;

            DisplayInOrderTraversal(root.left);
            Console.Write(root.data + " ");
            DisplayInOrderTraversal(root.right);
        }

        public void DisplayPreOrderTraversal(TreeNode root)
        {
            if (root == null)
                return;

            Console.Write(root.data + " ");
            DisplayPreOrderTraversal(root.left);
            DisplayPreOrderTraversal(root.right);
        }

        public void DisplayPostOrderTraversal(TreeNode root)
        {
            if (root == null)
                return;

            DisplayPostOrderTraversal(root.left);
            DisplayPostOrderTraversal(root.right);
            Console.Write(root.data + " ");
        }
    }
}