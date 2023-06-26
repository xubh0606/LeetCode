using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _295_MedianFinder
    {
        int m_balance;
        IList<int> m_bigHeap;
        IList<int> m_smallHeap;

        public _295_MedianFinder()
        {
            m_balance = 0;
            m_bigHeap = new List<int>();
            m_smallHeap = new List<int>();
        }

        public void AddNum(int num)
        {
            if (m_bigHeap.Count == 0 || num > m_bigHeap[0])
            {
                m_smallHeap.Add(num);
                UpSmallHeap();
                m_balance--;
            }
            else
            {
                m_bigHeap.Add(num);
                UpBigHeap();
                m_balance++;
            }
        }

        public double FindMedian()
        {
            Balance();
            if (m_balance == 0)
            {
                return ((double)m_bigHeap[0] + (double)m_smallHeap[0]) / 2;
            }
            else
            {
                return m_balance < 0 ? m_smallHeap[0] : m_bigHeap[0];
            }
        }

        void DownBigHeap()
        {
            int count = m_bigHeap.Count;
            int father = 0;
            while (true)
            {
                int leftChild = father * 2 + 1;
                int rightChild = father * 2 + 2;
                int max = father;
                if (leftChild < count && m_bigHeap[father] < m_bigHeap[leftChild])
                {
                    max = leftChild;
                }
                if (rightChild < count && m_bigHeap[max] < m_bigHeap[rightChild])
                {
                    max = rightChild;
                }
                if (max == father)
                {
                    break;
                }
                Swap(m_bigHeap, max, father);
                father = max;
            }
        }
        void DownSmallHeap()
        {
            int father = 0;
            int count = m_smallHeap.Count;
            while (true)
            {
                int leftChild = father * 2 + 1;
                int rightChild = father * 2 + 2;
                int min = father;
                if (leftChild < count && m_smallHeap[father] > m_smallHeap[leftChild])
                {
                    min = leftChild;
                }
                if (rightChild < count && m_smallHeap[min] > m_smallHeap[rightChild])
                {
                    min = rightChild;
                }
                if (min == father)
                {
                    break;
                }
                Swap(m_smallHeap, min, father);
                father = min;
            }
        }
        void Swap(IList<int> list, int a, int b)
        {
            int temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }

        void Balance()
        {
            if (m_balance < -1)
            {
                while (m_balance < -1)
                {
                    m_balance += 2;
                    m_bigHeap.Add(m_smallHeap[0]);
                    UpBigHeap();
                    Swap(m_smallHeap, 0, m_smallHeap.Count - 1);
                    m_smallHeap.RemoveAt(m_smallHeap.Count - 1);
                    DownSmallHeap();
                }
            }
            else if (m_balance > 1)
            {
                while (m_balance > 1)
                {
                    m_balance -= 2;
                    m_smallHeap.Add(m_bigHeap[0]);
                    UpSmallHeap();
                    Swap(m_bigHeap, 0, m_bigHeap.Count - 1);
                    m_bigHeap.RemoveAt(m_bigHeap.Count - 1);
                    DownBigHeap();
                }
            }
        }

        void UpBigHeap()
        {
            int start = m_bigHeap.Count - 1;
            while (start > 0)
            {
                int father = (start - 1) / 2;
                if (m_bigHeap[father] < m_bigHeap[start])
                {
                    Swap(m_bigHeap, father, start);
                    start = father;
                }
                else
                {
                    break;
                }
            }
        }
        void UpSmallHeap()
        {
            int start = m_smallHeap.Count - 1;
            while (start > 0)
            {
                int father = (start - 1) / 2;
                if (m_smallHeap[father] > m_smallHeap[start])
                {
                    Swap(m_smallHeap, father, start);
                    start = father;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
