using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    //序列化二叉树的一种方法是使用 前序遍历 。
    //当我们遇到一个非空节点时，我们可以记录下这个节点的值。
    //如果它是一个空节点，我们可以使用一个标记值记录，例如 #。
    //给定一串以逗号分隔的序列，验证它是否是正确的二叉树的前序序列化
    public class _331_IsValidSerialization
    {
        string isNull = "#";
        string[] m_str;
        int m_index;
        public bool IsValidSerialization(string preorder)
        {
            m_str = preorder.Split(new char[] { ',' });
            m_index = 0;
            if (Cheak())
            {
                if (m_index == m_str.Length)
                {
                    return true;
                }
            }
            return false;
        }
        bool Cheak()
        {
            if(m_index >= m_str.Length)
            {
                return false;
            }
            if(m_str[m_index] != isNull)
            {
                m_index++;
                if(m_index + 2 > m_str.Length)
                {
                    return false;
                }
                if (Cheak() && Cheak())
                {
                    return true;
                }
                return false;
            }
            m_index++;
            return true;
        }
    }
}
