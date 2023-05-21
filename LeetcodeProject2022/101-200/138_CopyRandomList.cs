using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{

    // Definition for a _138_Node.
    public class _138_Node
    {
        public int val;
        public _138_Node next;
        public _138_Node random;

        public _138_Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
    public class _138_CopyRandomList
    {
        public _138_Node CopyRandomList(_138_Node head)
        {
            if (head == null)
            {
                return null;
            }
            _138_Node new_head = new _138_Node(head.val);
            _138_Node cur = head.next;
            _138_Node new_cur = new_head;
            Dictionary<_138_Node, _138_Node> nodeDic = new Dictionary<_138_Node, _138_Node>();
            nodeDic.Add(head, new_head);
            while (cur != null)
            {
                _138_Node nextNode = new _138_Node(cur.val);
                nodeDic.Add(cur, nextNode);
                new_cur.next = nextNode;
                cur = cur.next;
                new_cur = new_cur.next;
            }
            cur = head;
            new_cur = new_head;
            while (cur != null)
            {
                if (cur.random != null)
                {
                    new_cur.random = nodeDic[cur.random];
                }
                cur = cur.next;
                new_cur = new_cur.next;
            }
            return new_head;
        }
    }
}
