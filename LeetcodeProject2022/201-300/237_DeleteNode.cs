using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _237_DeleteNode
    {
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            if (node.next.next == null)
            {
                node.next = null;
                return;
            }
            DeleteNode(node.next);
        }
    }
}
