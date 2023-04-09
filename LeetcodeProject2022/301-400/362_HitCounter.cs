using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _362_HitCounter
    {
        Queue<int> m_hitCountQueue;
        public _362_HitCounter()
        {
            m_hitCountQueue = new Queue<int>();
        }

        public void Hit(int timestamp)
        {
            m_hitCountQueue.Enqueue(timestamp);
        }

        public int GetHits(int timestamp)
        {
            while (m_hitCountQueue.Count != 0 && m_hitCountQueue.Peek() + 300 <= timestamp)
            {
                m_hitCountQueue.Dequeue();
            }
            return m_hitCountQueue.Count;
        }
    }

    /**
     * Your HitCounter object will be instantiated and called as such:
     * HitCounter obj = new HitCounter();
     * obj.Hit(timestamp);
     * int param_2 = obj.GetHits(timestamp);
     */
}
