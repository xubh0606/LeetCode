using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _381_RandomizedCollection
    {
        IList<int> m_randomizedCollectionSet;
        Dictionary<int, HashSet<int>> m_randomizedCollectionDic;
        Random m_random;
        public _381_RandomizedCollection()
        {
            m_random = new Random();
            m_randomizedCollectionDic = new Dictionary<int, HashSet<int>>();
            m_randomizedCollectionSet = new List<int>();
        }

        public bool Insert(int val)
        {
            if (!m_randomizedCollectionDic.ContainsKey(val))
            {
                m_randomizedCollectionDic.Add(val, new HashSet<int>());
                m_randomizedCollectionDic[val].Add(m_randomizedCollectionSet.Count);
                m_randomizedCollectionSet.Add(val);
                return true;
            }
            if (m_randomizedCollectionDic[val].Count == 0)
            {
                m_randomizedCollectionDic[val].Add(m_randomizedCollectionSet.Count);
                m_randomizedCollectionSet.Add(val);
                return true;
            }
            m_randomizedCollectionDic[val].Add(m_randomizedCollectionSet.Count);
            m_randomizedCollectionSet.Add(val);
            return false;
        }

        public bool Remove(int val)
        {
            if (!m_randomizedCollectionDic.ContainsKey(val))
            {
                return false;
            }
            if (m_randomizedCollectionDic[val].Count == 0)
            {
                return false;
            }
            int end = m_randomizedCollectionSet.Count - 1;
            HashSet<int> list = m_randomizedCollectionDic[val];
            if (list.Contains(end))
            {
                list.Remove(end);
                m_randomizedCollectionSet.RemoveAt(end);
                return true;
            }
            int valPlace = list.First();
            //将元素换至末尾
            HashSet<int> list2 = m_randomizedCollectionDic[m_randomizedCollectionSet[end]];
            //删除此时在末尾位置的元素
            list.Remove(valPlace);
            list2.Add(valPlace);
            list2.Remove(end);
            m_randomizedCollectionSet[valPlace] = m_randomizedCollectionSet[end];
            m_randomizedCollectionSet.RemoveAt(end);
            return true;
        }

        public int GetRandom()
        {
            return m_randomizedCollectionSet[m_random.Next(m_randomizedCollectionSet.Count)];
        }
    }

    /**
     * Your RandomizedCollection object will be instantiated and called as such:
     * RandomizedCollection obj = new RandomizedCollection();
     * bool param_1 = obj.Insert(val);
     * bool param_2 = obj.Remove(val);
     * int param_3 = obj.GetRandom();
     */
}
