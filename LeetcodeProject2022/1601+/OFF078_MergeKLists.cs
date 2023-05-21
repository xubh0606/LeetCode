using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_
{
    public class OFF078_MergeKLists
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            int n = lists.Length;
            if (n == 0)
            {
                return null;
            }
            if (n == 1)
            {
                return lists[0];
            }
            int k = 0;
            for (int d = 0; d < n; d++)
            {
                if (lists[d] != null)
                {
                    k++;
                }
            }
            ListNode[] FirstNode = new ListNode[k];
            int j = 0;
            for (int b = 0; b < n; b++)
            {
                if (lists[b] == null)
                {
                    continue;
                }
                FirstNode[j] = lists[b];
                j++;
            }
            if (k == 0)
            {
                return null;
            }
            for (int i = (k - 1) / 2; i >= 0; i--)
            {
                HeapVal(FirstNode, i, k);
            }
            ListNode ans = new ListNode(0);
            ListNode dummy_head = ans;
            while (k - 1 > 0)
            {
                dummy_head.next = FirstNode[0];
                if (FirstNode[0].next != null)
                {
                    FirstNode[0] = FirstNode[0].next;
                    dummy_head.next.next = null;
                }
                else
                {
                    FirstNode[0] = FirstNode[k - 1];
                    k--;

                }
                dummy_head = dummy_head.next;
                HeapVal(FirstNode, 0, k);
            }
            dummy_head.next = FirstNode[0];
            return ans.next;
        }
        void HeapVal(ListNode[] lists, int i, int n)
        {
            while (i * 2 + 1 < n)
            {
                int lSon = i * 2 + 1;
                int rSon = i * 2 + 2;
                int small = i;
                if (lists[lSon].val < lists[i].val)
                {
                    small = lSon;
                }
                if (rSon < n && lists[rSon].val < lists[small].val)
                {
                    small = rSon;
                }
                if (small != i)
                {
                    SwapListNode(lists, small, i);
                    i = small;
                }
                else
                {
                    break;
                }
            }
            return;
        }

        private void SwapListNode(ListNode[] lists, int i, int j)
        {
            ListNode temp = lists[i];
            lists[i] = lists[j];
            lists[j] = temp;
            return;
        }
    }
}
