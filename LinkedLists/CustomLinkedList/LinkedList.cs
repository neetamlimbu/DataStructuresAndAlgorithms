namespace CustomLinkedList
{
    public class LinkedList
    {
        Node headNode;

        public LinkedList()
        {
            headNode = null;
        }

        public void AddToEnd(int data)
        {
            if(headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
               headNode.Add(data);
            }
        }

        public void AddToBeginning(int data)
        {
            if(headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp;
            }
        }

         public void AddSorted(int data)
        {
            if(headNode == null)
            {
                headNode = new Node(data);
            }
            else if(data < headNode.data)
            {
                AddToBeginning(data);
            }
            else
            {
                headNode.AddSorted(data);
            }
        }

        public void Display()
        {
            if(headNode != null)
            {
                headNode.Print();
            }
        }
    }
}