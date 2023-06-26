using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _234_IsPalindrome
    {
        public bool IsPalindrome(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            ListNode left = Reverse(head, slow);
            if (fast.next == null)
            {
                return Compare(left, slow.next);
            }
            else
            {
                if (slow.val != slow.next.val)
                {
                    return false;
                }
                return Compare(left, slow.next.next);
            }
        }
        ListNode Reverse(ListNode head, ListNode end)
        {
            if (head == end)
            {
                return null;
            }
            ListNode new_head = head;
            head = head.next;
            new_head.next = null;
            while (head != end)
            {
                ListNode temp = head.next;
                head.next = new_head;
                new_head = head;
                head = temp;
            }
            return new_head;
        }
        bool Compare(ListNode left, ListNode right)
        {
            while (left != null)
            {
                if (left.val != right.val)
                {
                    return false;
                }
                left = left.next;
                right = right.next;
            }
            return true;
        }
    }
}
