using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1001_1100
{
    public class _1096_BraceExpansionII
    {
        int m_index;
        int m_len;
        public IList<string> BraceExpansionII(string expression)
        {
            m_index = 0;
            m_len = expression.Length;
            return FindIn(expression, GetStr(expression)).OrderBy(u => u).ToList();
        }
        //递归判断进入的是什么类型的元素，执行对应的法则
        IList<string> FindIn(string expression, IList<string> list)
        {
            //同层的叠加考虑
            while (m_index < expression.Length && expression[m_index] != '}')
            {
                m_index++;
                Union(list, GetStr(expression));
            }
            m_index++;
            return list;
        }
        IList<string> GetStr(string expression)
        {
            IList<string> list = new List<string>();
            while (m_index < m_len && expression[m_index] != ',')
            {
                if (expression[m_index] == '}')
                {
                    return list;
                }
                else if (expression[m_index] == '{')
                {
                    m_index++;
                    list = Concatenations(list, FindIn(expression, GetStr(expression)));
                }
                else
                {
                    string s = "";
                    while (m_index < m_len && expression[m_index] != ',' && expression[m_index] != '}' && expression[m_index] != '{')
                    {
                        s += expression[m_index];
                        m_index++;
                    }
                    IList<string> list2 = new List<string>();
                    list2.Add(s);
                    list = Concatenations(list, list2);
                }
            }
            return list;
        }
        //交乘法则
        IList<string> Concatenations(IList<string> list1, IList<string> list2)
        {
            if (list1.Count == 0)
            {
                return list2;
            }
            HashSet<string> set = new HashSet<string>();
            IList<string> new_list = new List<string>();
            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    string s = list1[i] + list2[j];
                    if (!set.Contains(s))
                    {
                        new_list.Add(s);
                        set.Add(s);
                    }
                }
            }
            return new_list;
        }
        //相加法则
        void Union(IList<string> list1, IList<string> list2)
        {
            if (list1.Count == 0)
            {
                list1 = list2;
            }
            HashSet<string> set = new HashSet<string>();
            for (int j = 0; j < list1.Count; j++)
            {
                set.Add(list1[j]);
            }
            for (int i = 0; i < list2.Count; i++)
            {
                if (!set.Contains(list2[i]))
                {
                    set.Add(list2[i]);
                    list1.Add(list2[i]);
                }
            }
        }
    }
}
