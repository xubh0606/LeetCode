using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022.LeetCodeTools
{
    public class MyLinkedList<T>
    {
        internal MyLinkedListNode<T> m_head;
    }
    public class MyLinkedListNode<T>
    { 
        internal MyLinkedList<T> m_list;

        internal MyLinkedListNode<T> m_next;

        internal MyLinkedListNode<T> m_prev;

        internal T m_item;

        public MyLinkedListNode(T value)
        {
            this.m_item = value;
        }
        internal MyLinkedListNode(MyLinkedList<T> list, T value)
        {
            this.m_list = list;
            this.m_item = value;
        }
        public MyLinkedList<T> List
        {
            get
            {
                return this.m_list;
            }
        }
        public MyLinkedListNode<T> Next
        {
            get{
                if(this.m_next != null && this.m_next != this.m_list.m_head)
                {
                    return this.m_next;
                }
                return null;
            }
        }
    }
}
