using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    //栈实现队列
    public class _232_MyQueue
    {
        Stack<int> m_save;
        Stack<int> m_temp;
        public _232_MyQueue()
        {
            m_save = new Stack<int>();
            m_temp = new Stack<int>();
        }

        public void Push(int x)
        {
            m_save.Push(x);
        }

        public int Pop()
        {
            if (Empty())
            {
                return -1;
            }
            if (m_temp.Count != 0)
            {
                return m_temp.Pop();
            }
            while (m_save.Count > 1)
            {
                m_temp.Push(m_save.Pop());
            }
            return m_save.Pop();
        }

        public int Peek()
        {
            if (Empty())
            {
                throw new Exception();
            }
            if (m_temp.Count != 0)
            {
                return m_temp.Peek();
            }
            while (m_save.Count > 0)
            {
                m_temp.Push(m_save.Pop());
            }
            return m_temp.Peek();
        }

        public bool Empty()
        {
            return m_temp.Count == 0 && m_save.Count == 0;
        }
    }
}
