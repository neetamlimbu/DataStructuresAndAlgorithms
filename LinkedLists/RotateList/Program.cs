using System;

namespace RotateList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rotate List - LeetCode 61");

            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);

            ListNode rotated = RotateRightBruteForce(head, 2);

            // ListNode head = new ListNode(0);
            // head.next = new ListNode(1);
            // head.next.next = new ListNode(2);

            // ListNode rotated = RotateRight(head, 4);

            while (rotated != null)
            {
                Console.Write(rotated.val + " ");
                rotated = rotated.next;
            }
        }

        // 1 -> 2 -> 3 -> 4 -> 5   
        //If k = 5, linked list is original list
        //Any multiples of 5 will result into original list
        //Therefore, the number of rotations will be k modulus of length

        static ListNode RotateRightBruteForce(ListNode head, int k)
        {
            if (head == null || head.next == null || k == 0)
                return head;
           
            //Get the length of the linked list
            ListNode current = head;
            int length = 1;
            while(current.next != null)
            {
                length++;
                current = current.next;
            }

            //Create circular linked list
            current.next = head;

            //Compute k and last node
            k = k % length;
            int lastNodeIndex = length - k;

            //Loop through the last node index 
            while(lastNodeIndex > 0)
            {
                current = current.next;
                lastNodeIndex--;
            }

            head = current.next;
            current.next = null;

            return head;
        }
    }
}
