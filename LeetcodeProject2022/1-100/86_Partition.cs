using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _86_Partition
    {
        public ListNode Partition(ListNode head, int x)
        {
            //保留小的，单独存大的，最后合并
            ListNode bigHead = new ListNode(1);
            ListNode small_head = new ListNode(1);
            small_head.next = head;
            ListNode cur_head = small_head;
            head = bigHead;
            while (cur_head.next != null)
            {
                if (cur_head.next.val >= x)
                {
                    head.next = cur_head.next;
                    cur_head.next = head.next.next;
                    head = head.next;
                    head.next = null;
                }
                else
                {
                    cur_head = cur_head.next;
                }
            }
            cur_head.next = bigHead.next;
            return small_head.next;
        }
    }
}
