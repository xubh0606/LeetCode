using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetcodeProject2022;

namespace LeetcodeProject2022._101_200
{
    public class _141_HasCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null)
            {
                return false;
            }
            head.val = int.MaxValue;
            while (head.next != null)
            {
                head = head.next;
                if (head.val == int.MaxValue)
                {
                    return true;
                }
                head.val = int.MaxValue;
            }
            return false;
        }
    }
}
