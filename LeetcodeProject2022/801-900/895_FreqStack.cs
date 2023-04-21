using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900
{
    public class _895_FreqStack
    {
        IList<int> m_stackHeap;//维护大根堆，保证输出为要求的值
        Dictionary<int, IList<int>> m_numProperty;//记录val对应的时间和数量
        int m_count;//记录入栈时间
        public _895_FreqStack()
        {
            m_numProperty = new Dictionary<int, IList<int>>();
            m_stackHeap = new List<int>();
            m_count = 0;
        }

        public void Push(int val)
        {
            m_count++;
            if (m_numProperty.ContainsKey(val))
            {
                m_numProperty[val][0]++;
                m_numProperty[val].Add(m_count);
                HeapUp(m_numProperty[val][1]);
            }
            else
            {
                IList<int> list = new List<int>();
                list.Add(1);
                list.Add(m_stackHeap.Count);
                list.Add(m_count);
                m_numProperty.Add(val, list);
                m_stackHeap.Add(val);
                HeapUp(m_numProperty[val][1]);
            }
        }

        public int Pop()
        {
            int res = m_stackHeap[0];
            m_numProperty[res][0]--;
            if (m_numProperty[res][0] == 0)
            {
                HeapRemove();
            }
            else
            {
                m_numProperty[res].RemoveAt(m_numProperty[res].Count - 1);
                HeapDown();
            }
            return res;
        }

        private void HeapRemove()
        {
            int end = m_stackHeap.Count - 1;
            m_numProperty.Remove(m_stackHeap[0]);
            m_numProperty[m_stackHeap[end]][1] = 0;
            m_stackHeap[0] = m_stackHeap[end];
            m_stackHeap.RemoveAt(end);
            HeapDown();
        }

        private void HeapUp(int start)
        {
            while (start > 0)
            {
                int father = (start - 1) / 2;
                if (IsUp(start, father))
                {
                    Swap(father, start);
                    start = father;
                }
                else
                {
                    break;
                }
            }
        }

        private void HeapDown()
        {
            int father = 0;
            int len = m_stackHeap.Count;
            while (father < len)
            {
                int lSon = father * 2 + 1;
                int rSon = father * 2 + 2;
                int max = father;
                if (lSon < len && IsUp(lSon, father))
                {
                    max = lSon;
                }
                if (rSon < len && IsUp(rSon, max))
                {
                    max = rSon;
                }
                if (max == father)
                {
                    break;
                }
                Swap(father, max);
                father = max;
            }
        }

        private bool IsUp(int index1, int index2)
        {
            IList<int> a = m_numProperty[m_stackHeap[index1]];
            IList<int> b = m_numProperty[m_stackHeap[index2]];
            if (a[0] > b[0])
            {
                return true;
            }
            else if (a[0] == b[0])
            {
                if (a[a.Count - 1] > b[b.Count - 1])
                {
                    return true;
                }
            }
            return false;
        }

        private void Swap(int a, int b)
        {
            int valA = m_stackHeap[a];
            int valB = m_stackHeap[b];
            m_stackHeap[a] = valB;
            m_stackHeap[b] = valA;
            m_numProperty[valA][1] = b;
            m_numProperty[valB][1] = a;
        }
    }
}
