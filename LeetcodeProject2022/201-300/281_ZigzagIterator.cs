using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _281_ZigzagIterator
    {
        IList<int> m_v1, m_v2;
        int count1, count2;
        public _281_ZigzagIterator(IList<int> v1, IList<int> v2)
        {
            m_v1 = v1;
            m_v2 = v2;
            count1 = 0;
            count2 = 0;
        }

        public bool HasNext()
        {
            if (count1 < m_v1.Count || count2 < m_v2.Count)
            {
                return true;
            }
            return false;
        }

        public int Next()
        {
            if (HasNext())
            {
                if (count1 < m_v1.Count && count2 < m_v2.Count)
                {
                    if (count1 > count2)
                    {
                        return m_v2[count2++];
                    }
                    else
                    {
                        return m_v1[count1++];
                    }
                }
                return count1 == m_v1.Count ? m_v2[count2++] : m_v1[count1++];
            }
            throw new Exception();
        }
    }

    /**
     * Your ZigzagIterator will be called like this:
     * ZigzagIterator i = new ZigzagIterator(v1, v2);
     * while (i.HasNext()) v[f()] = i.Next();
     */
}
