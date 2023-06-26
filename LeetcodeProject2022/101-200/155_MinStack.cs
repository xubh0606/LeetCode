using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(val);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */

    public class _155_MinStack
    {
        Stack<int> m_stackOut;
        Stack<int> m_stackMin;
        public _155_MinStack()
        {
            m_stackMin = new Stack<int>();
            m_stackOut = new Stack<int>();
        }

        public void Push(int val)
        {
            m_stackOut.Push(val);
            if (m_stackMin.Count == 0)
            {
                m_stackMin.Push(val);
            }
            else
            {
                int cur = m_stackMin.Peek();
                if (cur < val)
                {
                    m_stackMin.Push(cur);
                }
                else
                {
                    m_stackMin.Push(val);
                }
            }
        }

        public void Pop()
        {
            m_stackOut.Pop();
            m_stackMin.Pop();
        }

        public int Top()
        {
            return m_stackOut.Peek();
        }

        public int GetMin()
        {
            return m_stackMin.Peek();
        }
    }
}
