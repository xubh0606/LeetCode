using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _24_SwapPairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            ListNode new_head = new ListNode(0);
            new_head.next = head;
            ListNode cur_head = new_head;
            while (cur_head.next != null && cur_head.next.next != null)
            {
                ListNode temp1 = cur_head.next.next;
                ListNode end = temp1.next;
                temp1.next = cur_head.next;
                cur_head.next = temp1;
                temp1.next.next = end;
                cur_head = temp1.next;
            }
            return new_head.next;
        }
    }
}
