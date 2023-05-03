using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _92_ReverseBetween
    {
        int m_end;
        ListNode m_right;
        //两种思路，递归，先找再正常反转再续接
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            ListNode total_head = new ListNode(0);
            total_head.next = head;
            m_end = right;
            head = total_head;
            for (int i = 0; i < left - 1; i++)
            {
                head = head.next;
            }
            ListNode cur_head = head.next;
            FindRight(cur_head, left);
            head.next = m_right;
            while (cur_head != null)
            {
                ListNode temp = cur_head.next;
                cur_head.next = head.next;
                head.next = cur_head;
                cur_head = temp;
            }
            return total_head.next;
        }
        void FindRight(ListNode cur_head, int count)
        {
            if (count == m_end)
            {
                m_right = cur_head.next;
                cur_head.next = null;
            }
            else
            {
                if (cur_head.next == null)
                {
                    m_right = null;
                    return;
                }
                FindRight(cur_head.next, count + 1);
            }
        }
    }
}
