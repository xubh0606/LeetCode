using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800
{
    public class _707_MyLinkedList
    {//这里跳表建立不了，因为找不到index
        _707_ListNode m_head;
        public _707_MyLinkedList()
        {
            m_head = new _707_ListNode();
        }

        public int Get(int index)
        {
            _707_ListNode cur_node = m_head.next;
            if (cur_node == null)
            {
                return -1;
            }
            while (index > 0)
            {
                cur_node = cur_node.next;
                if (cur_node == null)
                {
                    return -1;
                }
                index--;
            }
            return cur_node.val;
        }

        public void AddAtHead(int val)
        {
            _707_ListNode new_node = new _707_ListNode(val);
            new_node.next = m_head.next;
            m_head.next = new_node;
        }

        public void AddAtTail(int val)
        {
            _707_ListNode cur_node = m_head;
            while (cur_node.next != null)
            {
                cur_node = cur_node.next;
            }
            cur_node.next = new _707_ListNode(val);
        }

        public void AddAtIndex(int index, int val)
        {
            _707_ListNode cur_node = GetNodeBeforeIndex(index);
            if (cur_node != null)
            {
                _707_ListNode new_node = new _707_ListNode(val);
                new_node.next = cur_node.next;
                cur_node.next = new_node;
            }
        }

        public void DeleteAtIndex(int index)
        {
            _707_ListNode cur_node = GetNodeBeforeIndex(index);
            if (cur_node != null && cur_node.next != null)
            {
                cur_node.next = cur_node.next.next;
            }
        }

        _707_ListNode GetNodeBeforeIndex(int index)
        {
            _707_ListNode cur_node = m_head;
            while (index > 0)
            {
                cur_node = cur_node.next;
                index--;
                if (cur_node == null)
                {
                    return null;
                }
            }
            return cur_node;
        }
    }
    public class _707_ListNode
    {
        public int val;
        public _707_ListNode next;

        public _707_ListNode()
        {
            next = null;
            this.val = -1;
        }
        public _707_ListNode(int val)
        {
            next = null;
            this.val = val;
        }
    }
}
