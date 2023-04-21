using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
        public static ListNode GetListNode(int[] arr)
        {
            ListNode start_Node = new ListNode(0);
            if (arr.Length > 0)
            {
                start_Node = new ListNode(arr[0]);
            }
            else
            {
                return null;
            }
            ListNode head = start_Node;
            for(int i = 1; i < arr.Length; i++)
            {
                ListNode new_Node = new ListNode(arr[i]);
                start_Node.next = new_Node;
                start_Node = new_Node;
            }
            return head;
        }
    }
}
