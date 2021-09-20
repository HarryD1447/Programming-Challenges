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
            //Blank first node so return the linked list from the second position (index 1)
            ListNode returnValue = new ListNode();
            ListNode previousValue = returnValue;

            while (l1 != null || l2 != null)
            {
                if (l1 == null)
                {
                    //Add l2
                    previousValue.next = 
                }
                else if (l2 == null)
                {
                    //Add l1
                }
                else
                {
                    //Comparison
                    if (l1.val < l2.val)
                    {
                        //Add l1
                    }
                    else
                    {
                        //Add l2
                    }
                }
            }
        }
    }
}
