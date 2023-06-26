using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _432_AllOne
    {
        //建立计数哈希，在增删时每次调整对应计数的位置
        Dictionary<string, _432_Node> m_NodePlace;
        _432_Node head;
        _432_Node tail;
        public _432_AllOne()
        {
            m_NodePlace = new Dictionary<string, _432_Node>();
            head = new _432_Node(-1);
            tail = new _432_Node(-1);
            head.next = tail;
            tail.prev = head;
        }

        public void Inc(string key)
        {
            //如果存在，则向前移动一位
            if (m_NodePlace.ContainsKey(key))
            {
                _432_Node place = m_NodePlace[key];
                int val = place.val;
                if (place.next.val == val + 1)
                {
                    place.next.strSet.Add(key);
                }
                else
                {
                    _432_Node new_node = new _432_Node(val + 1);
                    new_node.strSet = new HashSet<string>();
                    new_node.next = place.next;
                    place.next.prev = new_node;
                    place.next = new_node;
                    new_node.prev = place;
                    new_node.strSet.Add(key);
                }
                place.strSet.Remove(key);
                if (place.strSet.Count == 0)
                {
                    place.prev.next = place.next;
                    place.next.prev = place.prev;
                }
                m_NodePlace[key] = place.next;
            }
            else
            {
                if(head.next.val == 1)
                {
                    head.next.strSet.Add(key);
                    m_NodePlace.Add(key, head.next);
                }
                else
                {
                    _432_Node new_node = new _432_Node(1);
                    new_node.strSet = new HashSet<string>();
                    new_node.next = head.next;
                    head.next.prev = new_node;
                    head.next = new_node;
                    new_node.prev = head;
                    new_node.strSet.Add(key);
                    m_NodePlace.Add(key, new_node);
                }
            }
        }

        public void Dec(string key)
        {
            if (m_NodePlace.ContainsKey(key))
            {
                _432_Node place = m_NodePlace[key];
                if (place.val == 1)
                {
                    m_NodePlace.Remove(key);
                    if (place.strSet.Count == 1)
                    {
                        place.next.prev = head;
                        head.next = place.next;
                    }
                    else
                    {
                        place.strSet.Remove(key);
                    }
                }
                else
                {
                    int val = place.val;
                    place.strSet.Remove(key);
                    if (place.prev.val == val - 1)
                    {
                        place.prev.strSet.Add(key);
                        m_NodePlace[key] = place.prev;
                    }
                    else
                    {
                        _432_Node new_node = new _432_Node(val - 1);
                        place.prev.next = new_node;
                        new_node.prev = place.prev;
                        new_node.next = place;
                        place.prev = new_node;
                        new_node.strSet = new HashSet<string>();
                        new_node.strSet.Add(key);
                        m_NodePlace[key] = new_node;
                    }

                    if (place.strSet.Count == 0)
                    {
                        place.prev.next = place.next;
                        place.next.prev = place.prev;
                    }
                }
            }
            else
            {
                throw new ArgumentException("Not ContainsKey");
            }
        }

        public string GetMaxKey()
        {
            if (tail.prev == head)
            {
                return "";
            }
            return tail.prev.strSet.ElementAt(0);
        }

        public string GetMinKey()
        {
            if (head.next == tail)
            {
                return "";
            }
            return head.next.strSet.ElementAt(0);
        }
    }

    public class _432_Node
    {
        public int val;
        public _432_Node next;
        public _432_Node prev;
        public HashSet<string> strSet;
        public _432_Node(int val)
        {
            this.val = val;
        }
    }
}
