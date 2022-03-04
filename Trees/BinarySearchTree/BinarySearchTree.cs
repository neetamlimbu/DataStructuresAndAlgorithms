using System;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        private TreeNode root;

        public BinarySearchTree()
        {
            root = null;
        }

        private void AddTreNode(int value)
        {
            if (root == null)
            {
                root = new TreeNode(value);
            }
            else
            {
                root.AddTreeNode(value);
            }
        }

        public TreeNode BuildBinarySearchTree(int[] arr, int index)
        {
            if (index >= arr.Length)
                return null;

            AddTreNode(arr[index]);
            BuildBinarySearchTree(arr, index + 1);

            return root;
        }

        public void InOrderTraversal()
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

        public void PreOrderTraversal()
        {
            PreOrder(root);
        }

        public void PreOrder(TreeNode treeNode)
        {
            if (treeNode == null)
                return;

            Console.Write(treeNode.data + " ");
            PreOrder(treeNode.left);
            PreOrder(treeNode.right);
        }

        public void PostOrderTraversal()
        {
            PostOrder(root);
        }

        public void PostOrder(TreeNode treeNode)
        {
            if (treeNode == null)
                return;

            PostOrder(treeNode.left);
            PostOrder(treeNode.right);
            Console.Write(treeNode.data + " ");
        }

        public void Search(int number)
        {
            Search(root, number);
        }

        private void Search(TreeNode treeNode, int number)
        {
            if (treeNode == null)
                return;

            if (treeNode.data > number && treeNode.left != null)
            {
                Search(treeNode.left, number);
            }
            else if (treeNode.data < number && treeNode.right != null)
            {
                Search(treeNode.right, number);
            }
            else if (treeNode.data == number)
            {
                Console.WriteLine("Number {0} found", number);
                return;
            }
            else
            {
                Console.WriteLine("Number {0} not found", number);
            }
        }

        public int FindMin()
        {
            if (root == null)
                return -1;

            int min = FindMin(root);
            return min;
        }

        private int FindMin(TreeNode treeNode)
        {
            if (treeNode.left == null)
            {
                return treeNode.data;
            }

            return FindMin(treeNode.left);
        }

        public int FindMax()
        {
            if (root == null)
                return -1;

            int max = FindMax(root);
            return max;
        }

        private int FindMax(TreeNode treeNode)
        {
            if (treeNode.right == null)
            {
               return treeNode.data;
            }

            return  FindMax(treeNode.right);
        }
    }
}