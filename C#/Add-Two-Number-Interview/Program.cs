using System;
using System.Collections.Generic;

//https://leetcode.com/problems/add-two-numbers/

namespace Add_Two_Number_Interview
{
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


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
        {
            int numA = GetNumFromLinkList(l1);
            int numB = GetNumFromLinkList(l2);
            int addedValue = numA + numB;
            char[] number = addedValue.ToString().ToCharArray();

            ListNode buffer = null;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                ListNode node = new ListNode((int)number[i],buffer);
                buffer = node;
            }

            return buffer;
        }

        public int GetNumFromLinkList(ListNode linkedList)
        {
            List<char> charA = new List<char>();

            ListNode nextNode = linkedList;

            while(nextNode != null)
            {
                charA.Insert(0, nextNode.val.ToString());
                if (nextNode.next != null)
                {
                    nextNode = nextNode.next;
                } else {nextNode = null;}
            }

            return Int32.Parse( charA.ToString());
        }

    }
}
