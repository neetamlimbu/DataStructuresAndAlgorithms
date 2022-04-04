using System;

namespace RemoveNthNode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remove Nth Node From End of List - LeetCode 19");

            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);

            ListNode result = RemoveNthFromEnd(head, 1);
            while (result != null)
            {
                Console.WriteLine(result.val + " ");
                result = result.next;
            }
        }

        static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null)
                return head;

            int len = 0;
            ListNode current = head;

            while (current != null)
            {
                len++;
                current = current.next;
            }

            int target = len - n + 1;
            int selectedNode = 0;
            ListNode prev = null;
            current = head;
            while (current != null)
            {
                selectedNode++;
                if (selectedNode == target)
                {
                    ListNode next = current.next;
                    current = prev;
                    if (current != null)
                    {
                        current.next = next;
                    }
                    else
                    {
                        head = head.next; //head becomes null in case of single input node and n as 1
                    }
                }

                prev = current;

                if (current != null)
                    current = current.next;
            }

            return head;
        }
    }
}
