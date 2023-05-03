using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _346_MovingAverage
    {
        double m_total;
        Queue<int> m_MovingAverageQueue;
        int m_size;
        public _346_MovingAverage(int size)
        {
            m_total = 0;
            m_MovingAverageQueue = new Queue<int>();
            m_size = size;
        }

        public double Next(int val)
        {
            m_MovingAverageQueue.Enqueue(val);
            m_total += val;
            if (m_MovingAverageQueue.Count > m_size)
            {
                m_total -= m_MovingAverageQueue.Dequeue();
            }
            return m_total / m_MovingAverageQueue.Count;
        }
    }

    /**
     * Your MovingAverage object will be instantiated and called as such:
     * MovingAverage obj = new MovingAverage(size);
     * double param_1 = obj.Next(val);
     */
}
