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

        public void DisplayInOrderTraversal()
        {
            InOrder(root);
        }

        private void InOrder(TreeNode treeNode)
        {
            if (treeNode == null)
                return;

            InOrder(treeNode.left);
            Console.Write(treeNode.data + " ");
            InOrder(treeNode.right);
        }

        public void DisplayPreOrderTraversal()
        {
            PreOrder(root);
        }

        private void PreOrder(TreeNode treeNode)
        {
            if (treeNode == null)
                return;

            Console.Write(treeNode.data + " ");
            PreOrder(treeNode.left);
            PreOrder(treeNode.right);
        }

        public void DisplayPostOrderTraversal()
        {
            PostOrder(root);
        }

        private void PostOrder(TreeNode treeNode)
        {
            if (treeNode == null)
                return;

            PostOrder(treeNode.left);
            PostOrder(treeNode.right);
            Console.Write(treeNode.data + " ");
        }
    }
}