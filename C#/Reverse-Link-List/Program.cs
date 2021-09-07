using System;

namespace Reverse_Link_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
        }

        static ListNode ReverseList(ListNode head) 
        {
            ListNode previousNode = null;

            while (head != null)
            {
                ListNode next_node = head.next;
                head.next = previousNode;
                previousNode = head;
                head = next_node;
            }

            return previousNode;
        }
    }

    public class ListNode 
    {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) 
      {
         this.val = val;
          this.next = next;
      }
  }
}
