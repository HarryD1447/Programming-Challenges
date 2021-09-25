using System;

namespace Merge_Sorted_Linked_List_Interview
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    class Program
    {

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            try
            {
                ListNode primary = l2.val < l1.val ? l2 : l1;
                ListNode secondary = primary == l1 ? l2 : l1;
                ListNode firstNode = primary;
            }
            catch
            {
                //One or both of the link list is empty 
                if (l1 == null && l2 == null) { return new ListNode(); }
                else if (l1 == null) { return l2; }
                else { return l1; }
            }

            while (secondary != null)
            {
                if (primary.next != null && primary.next.val < secondary.val)
                {
                    //Primary next
                    primary = primary.next;
                }
                else
                {
                    //Secondary next
                    ListNode tempNext = primary.next;
                    ListNode secondaryNext = secondary.next;
                    primary.next = secondary;
                    primary.next.next = tempNext;
                    secondary = secondaryNext;

                    primary = primary.next;
                }
            }

            return firstNode;
        }
    }
}
