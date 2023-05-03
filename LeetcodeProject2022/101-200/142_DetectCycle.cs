using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _142_DetectCycle
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            ListNode fast = head;
            ListNode slow = head;
            while (fast.next != null && fast.next.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (fast == slow)
                {
                    fast = head;
                    while (fast != slow)
                    {
                        fast = fast.next;
                        slow = slow.next;

                    }
                    return slow;
                }
            }
            return null;
        }
    }
}
