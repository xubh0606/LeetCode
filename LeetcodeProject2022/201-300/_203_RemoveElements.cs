using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _203_RemoveElements
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
            {
                return null;
            }
            ListNode cur_head = head;
            while (cur_head.next != null)
            {
                if (cur_head.next.val != val)
                {
                    cur_head = cur_head.next;
                }
                else
                {
                    cur_head.next = cur_head.next.next;
                }
            }
            return head.val == val ? head.next : head;
        }
    }
}
