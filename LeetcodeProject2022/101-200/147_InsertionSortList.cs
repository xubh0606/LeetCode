using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _147_InsertionSortList
    {
        public ListNode InsertionSortList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            return InsertRest(head);
        }
        ListNode InsertRest(ListNode cur)
        {
            if (cur.next == null)
            {
                return cur;
            }
            ListNode rest = InsertRest(cur.next);
            cur.next = null;
            return Insert(cur, rest);
        }
        ListNode Insert(ListNode cur, ListNode rest)
        {
            if (rest.val > cur.val)
            {
                cur.next = rest;
                return cur;
            }
            ListNode head = rest;
            while (rest.next != null)
            {
                if (rest.next.val > cur.val)
                {
                    cur.next = rest.next;
                    rest.next = cur;
                    return head;
                }
                rest = rest.next;
            }
            rest.next = cur;
            return head;
        }
    }
}
