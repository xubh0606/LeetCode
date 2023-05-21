using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _83_DeleteDuplicates
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            HashSet<int> visited = new HashSet<int>();
            ListNode cur = new ListNode(0);
            cur.next = head;
            head = cur;
            while (head.next != null)
            {
                if (visited.Contains(head.next.val))
                {
                    head.next = head.next.next;
                }
                else
                {
                    visited.Add(head.next.val);
                    head = head.next;
                }
            }
            return cur.next;
        }
    }
}
