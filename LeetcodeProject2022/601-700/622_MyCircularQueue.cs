using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._601_700
{
    public class _622_MyCircularQueue
    {
        int[] m_circularQueue;
        int m_front;
        int m_maxCount;
        int m_rear;
        public _622_MyCircularQueue(int k)
        {
            m_circularQueue = new int[k];
            m_front = 0;
            m_rear = -1;
            m_maxCount = 0;
        }

        public bool EnQueue(int value)
        {
            if (IsFull())
            {
                return false;
            }
            m_rear++;
            if (m_rear == m_circularQueue.Length)
            {
                m_rear = 0;
            }
            m_maxCount++;
            m_circularQueue[m_rear] = value;
            return true;
        }

        public bool DeQueue()
        {
            if (IsEmpty())
            {
                return false;
            }
            m_front++;
            if (m_front == m_circularQueue.Length)
            {
                m_front = 0;
            }
            m_maxCount--;
            return true;
        }

        public int Front()
        {
            if (IsEmpty())
            {
                throw new ArgumentOutOfRangeException();
            }
            return m_circularQueue[m_front];
        }

        public int Rear()
        {

            if (IsEmpty())
            {
                throw new ArgumentOutOfRangeException();
            }
            return m_circularQueue[m_rear];
        }

        public bool IsEmpty()
        {
            return m_maxCount <= 0;
        }

        public bool IsFull()
        {
            return m_maxCount == m_circularQueue.Length;
        }
    }
}
