using System;
using System.Collections;

namespace MergeKSortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merge k Sorted Lists - LeetCode 23");

            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(5);

            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);

            ListNode l3 = new ListNode(2);
            l3.next = new ListNode(6);

            ListNode[] lists = { l1, l2, l3 };

            ListNode merged = MergeKLists(lists);
            while (merged != null)
            {
                Console.Write(merged.val + " ");
                merged = merged.next;
            }
        }

        static ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0)
                return null;

            ArrayList mergedList = new ArrayList();

            while (lists.Length > 1)
            {
                for (int i = 0; i < lists.Length; i = i + 2)
                {
                    ListNode l1 = lists[i];
                    ListNode l2 = null;

                    if ((i + 1) < lists.Length)
                        l2 = lists[i + 1];

                    mergedList.Add(MergeLists(l1, l2));
                }

                lists = (ListNode[])mergedList.ToArray(typeof(ListNode));
                mergedList.Clear();
            }

            return lists[0];
        }

        static ListNode MergeLists(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode();
            ListNode tail = dummy;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    tail.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    tail.next = l2;
                    l2 = l2.next;
                }

                tail = tail.next;
            }

            if (l1 != null)
                tail.next = l1;

            if (l2 != null)
                tail.next = l2;

            return dummy.next;
        }
    }
}
