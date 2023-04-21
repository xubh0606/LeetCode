using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class ListNode1
    {
        public int val;
        public int key;
        public ListNode1 next;
        public ListNode1 up;
        public ListNode1(int val = 0, ListNode1 next = null, ListNode1 up = null)
        {
            this.val = val;
            this.next = next;
            this.up = up;
        }
    }
    public class LRUCache
    {
        private int maxCount;
        private int count;
        private Dictionary<int, ListNode1> m_dic;
        private ListNode1 m_head;
        private ListNode1 m_end;
        public LRUCache(int capacity)
        {
            maxCount = capacity;
            count = 0;
            m_dic = new Dictionary<int, ListNode1>();
            m_head = new ListNode1(1);
            m_end = m_head;
        }

        public int Get(int key)
        {
            if (m_dic.ContainsKey(key))
            {
                ListNode1 temp = m_dic[key];
                int val2 = temp.val;
                if (temp.next != null)
                {
                    ListNode1 head = temp.up;
                    ListNode1 temp2 = new ListNode1(val2);
                    head.next = temp.next;
                    temp.next.up = head;
                    m_end.next = temp2;
                    temp2.up = m_end;
                    m_end = m_end.next;
                    m_dic[key] = temp2;
                    temp2.key = key;
                }
                return val2;
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            if (m_dic.ContainsKey(key))
            {
                ListNode1 temp = m_dic[key];
                if (temp.next != null)
                {
                    ListNode1 head = temp.up;
                    ListNode1 temp2 = new ListNode1(value);
                    head.next = temp.next;
                    temp.next.up = head;
                    m_end.next = temp2;
                    temp2.up = m_end;
                    m_end = m_end.next;
                    m_dic[key] = temp2;
                    temp2.key = key;
                }
                else
                {
                    temp.val = value;
                }
            }
            else
            {
                ListNode1 new_end = new ListNode1(value);
                m_dic.Add(key, new_end);
                new_end.key = key;
                m_end.next = new_end;
                new_end.up = m_end;
                m_end = m_end.next;
                count++;
                if (count > maxCount)
                {
                    m_head = m_head.next;
                    m_head.up = null;
                    count--;
                    m_dic.Remove(m_head.key);
                }
            }
        }
    }
    /**
     * Your LRUCache object will be instantiated and called as such:
     * LRUCache obj = new LRUCache(capacity);
     * int param_1 = obj.Get(key);
     * obj.Put(key,value);
     */
}
