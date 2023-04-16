using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800
{
    public class _708_Insert
    {
        public class _708_Node
        {
            public int val;
            public _708_Node next;

            public _708_Node() { }

            public _708_Node(int _val)
            {
                val = _val;
                next = null;
            }

            public _708_Node(int _val, _708_Node _next)
            {
                val = _val;
                next = _next;
            }
        }
        public _708_Node Insert(_708_Node head, int insertVal)
        {
            _708_Node new_node = new _708_Node(insertVal);
            if (head == null)
            {
                new_node.next = new_node;
                return new_node;
            }
            if (head.next == head)
            {
                new_node.next = head;
                head.next = new_node;
                return head;
            }
            _708_Node cur_head = head.next;
            while (cur_head.next.val >= cur_head.val)
            {
                cur_head = cur_head.next;
                if (cur_head == head)
                {
                    break;
                }
            }
            if (cur_head.val < insertVal)
            {
                new_node.next = cur_head.next;
                cur_head.next = new_node;
                return head;
            }
            while (cur_head.next.val < insertVal)
            {
                cur_head = cur_head.next;
            }
            new_node.next = cur_head.next;
            cur_head.next = new_node;
            return head;
        }
    }
}
