using System;
using System.Collections.Generic;

namespace Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intersection of Two Linked Lists - LeetCode 160");

            // list 1
            ListNode n1 = new ListNode(1);
            n1.next = new ListNode(2);
            n1.next.next = new ListNode(3);
            n1.next.next.next = new ListNode(4);
            n1.next.next.next.next = new ListNode(5);
            n1.next.next.next.next.next = new ListNode(6);
            n1.next.next.next.next.next.next = new ListNode(7);

            // list 2
            ListNode n2 = new ListNode(10);
            n2.next = new ListNode(9);
            n2.next.next = new ListNode(8);
            n2.next.next.next = n1.next.next.next;
            n2.next.next.next.next = new ListNode(5);
            n2.next.next.next.next.next = new ListNode(6);


            ListNode result = GetIntersectionNodeBruteForce(n1, n2);
            if (result == null)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("Using brute force - intersection point at " + result.val);
            }

            result = GetIntersectionNodeUsingSet(n1, n2);

            if (result == null)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("Using hashset - intersection point at " + result.val);
            }

            result = GetIntersectionNodeOptimal(n1, n2);

            if (result == null)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("Optimal solution - intersection point at " + result.val);
            }

            result = GetIntersectionNodeByLength(n1, n2);

            if (result == null)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("Using difference in length - intersection point at " + result.val);
            }

        }

        static ListNode GetIntersectionNodeBruteForce(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;

            ListNode tempA = headA;

            //Pick each node of linked list A
            while (tempA != null)
            {

                ListNode tempB = headB;

                //Find their reference in linked list B
                while (tempB != null)
                {

                    //If merge point is found, then return the merge point
                    if (tempA == tempB)
                    {
                        return tempA;
                    }

                    tempB = tempB.next;
                }

                tempA = tempA.next;
            }
            return null;
        }

        static ListNode GetIntersectionNodeUsingSet(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;

            HashSet<ListNode> listNodeSet = new HashSet<ListNode>();

            ListNode tempA = headA;


            while (tempA != null)
            {
                listNodeSet.Add(tempA);
                tempA = tempA.next;
            }

            ListNode tempB = headB;
            while (tempB != null)
            {
                if (listNodeSet.Contains(tempB))
                {
                    return tempB;
                }

                tempB = tempB.next;
            }

            return null;
        }

        static ListNode GetIntersectionNodeOptimal(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;

            ListNode a = headA;
            ListNode b = headB;

            while (a != b)
            {
                a = a == null ? headB : a.next;
                b = b == null ? headA : b.next;
            }

            return a;
        }

        static ListNode GetIntersectionNodeByLength(ListNode headA, ListNode headB)
        {
            ListNode tempA = headA;
            ListNode tempB = headB;

            int lenA = 0;
            int lenB = 0;

            while (tempA != null)
            {
                lenA++;
                tempA = tempA.next;
            }

            while (tempB != null)
            {
                lenB++;
                tempB = tempB.next;
            }

            int diff = Math.Abs(lenA - lenB);
            tempA = headA;
            tempB = headB;

            if (lenA > lenB)
            {
                while (diff-- > 0)
                    tempA = tempA.next;
            }
            else
            {
                while (diff-- > 0)
                    tempB = tempB.next;
            }

            while (tempA != tempB)
            {
                tempA = tempA.next;
                tempB = tempB.next;
                if (tempA == null || tempB == null)
                    return null;
            }
            return tempA;
        }
    }
}
