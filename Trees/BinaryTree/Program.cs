using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree...");

            BinaryTree binaryTree = new BinaryTree(4);
            TreeNode rootNode = binaryTree.root;
            TreeNode firstNode = new TreeNode(1);
            TreeNode secondNode = new TreeNode(3);
            TreeNode thirdNode = new TreeNode(8);
            TreeNode fourthNode = new TreeNode(9);
            TreeNode fifthNode = new TreeNode(6);
            rootNode.left = firstNode;
            rootNode.right = secondNode;
            firstNode.left = thirdNode;
            firstNode.right = fourthNode;
            secondNode.left = fifthNode;

            binaryTree.PreOrderTraversal(rootNode);
            Console.WriteLine();
            binaryTree.InOrderTraversal(rootNode);
            Console.WriteLine();
            binaryTree.PostOrderTraversal(rootNode);
            
        }
    }
}
