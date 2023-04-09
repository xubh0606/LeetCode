using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _380_RandomizedSet
    {
        IList<int> m_randomizedSet;
        Dictionary<int, int> m_randomizedDic;
        Random m_random;
        public _380_RandomizedSet()
        {
            m_randomizedSet = new List<int>();
            m_randomizedDic = new Dictionary<int, int>();
            m_random = new Random();
        }
        //插入其中时只需要放在尾端
        public bool Insert(int val)
        {
            if (m_randomizedDic.ContainsKey(val))
            {
                return false;
            }
            m_randomizedDic.Add(val, m_randomizedSet.Count);
            m_randomizedSet.Add(val);
            return true;
        }
        //删除时将尾端替换至中间,再删除末尾
        public bool Remove(int val)
        {
            if (m_randomizedDic.ContainsKey(val))
            {
                int valPlace = m_randomizedDic[val];
                //将元素换至末尾
                int end = m_randomizedSet.Count - 1;
                m_randomizedDic[m_randomizedSet[end]] = valPlace;
                m_randomizedSet[valPlace] = m_randomizedSet[end];
                //删除此时在末尾位置的元素
                m_randomizedDic.Remove(val);
                m_randomizedSet.RemoveAt(end);
                return true;
            }
            return false;
        }

        public int GetRandom()
        {
            return m_randomizedSet[m_random.Next(m_randomizedSet.Count)];
        }
    }

    /**
     * Your RandomizedSet object will be instantiated and called as such:
     * RandomizedSet obj = new RandomizedSet();
     * bool param_1 = obj.Insert(val);
     * bool param_2 = obj.Remove(val);
     * int param_3 = obj.GetRandom();
     */
}
