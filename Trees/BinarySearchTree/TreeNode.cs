namespace BinarySearchTree
{
    public class TreeNode
    {
        public int data;
        public TreeNode left, right;

        public TreeNode(int value)
        {
            data = value;
            left = right = null;
        }

        public void AddTreeNode(int value)
        {
           if(data > value)
           {
               if(left == null)
               {
                   left = new TreeNode(value);
               }
               else
               {
                   left.AddTreeNode(value);
               }
           }
           else if(data < value)
           {
               if(right == null)
               {
                   right = new TreeNode(value);
               }
               else
               {
                   right.AddTreeNode(value);
               }
           }
        }
    }
}