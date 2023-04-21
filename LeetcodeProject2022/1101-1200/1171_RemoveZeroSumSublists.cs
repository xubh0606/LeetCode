using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1101_1200
{
    public class _1171_RemoveZeroSumSublists
    {
        public ListNode RemoveZeroSumSublists(ListNode head)
        {
            bool exist = true;
            while (exist && head != null)
            {
                if (head.val == 0)
                {
                    head = head.next;
                    continue;
                }
                exist = false;
                ListNode cur_head = head;
                Dictionary<int, ListNode> sameNode = new Dictionary<int, ListNode>();
                int sum = head.val;
                sameNode.Add(0, null);
                sameNode.Add(sum, head);
                while (cur_head.next != null)
                {
                    sum += cur_head.next.val;
                    if (sameNode.ContainsKey(sum))
                    {
                        if (sum == 0)
                        {
                            head = cur_head.next.next;
                        }
                        else
                        {
                            sameNode[sum].next = cur_head.next.next;
                        }
                        exist = true;
                        break;
                    }
                    else
                    {
                        sameNode.Add(sum, cur_head.next);
                    }
                    cur_head = cur_head.next;
                }
            }
            return head;
        }
    }
}
