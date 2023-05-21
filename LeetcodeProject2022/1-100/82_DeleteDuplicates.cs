using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public  class _82_DeleteDuplicates
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode totalHead = new ListNode(0);
            totalHead.next = head;
            head = totalHead;
            while (head.next != null)
            {
                int num = head.next.val;
                bool changed = false;
                ListNode cur = head.next;
                while (cur.next != null)
                {
                    if (cur.next.val == num)
                    {
                        cur.next = cur.next.next;
                    }
                    else
                    {
                        break;
                    }
                    changed = true;
                }
                if (changed)
                {
                    head.next = head.next.next;
                }
                else
                {
                    head = head.next;
                }
            }
            return totalHead.next;
        }
    }
}
