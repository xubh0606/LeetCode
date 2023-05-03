using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _277__FindCelebrity
    {
        int[][] m_party;
        public _277__FindCelebrity(int[][] party)
            {
            m_party = party;
            }
        bool Knows(int a, int b)
        {
            if(a >= m_party.Length || b >= m_party[a].Length)
            {
                throw new IndexOutOfRangeException();
            }
            if(m_party[a][b] == 0)
            {
                return false;
            }
            return true;
        }
        //对任意一个人询问是否存在认识概念，如果存在一个人不认识某人，此时将他设置为待定名人
        //当剩下的人存在不认识他，则再次替换，找到完全不认识任何人为止
        public int FindCelebrity(int n)
        {
            int possibleCelebrity = 0;
            int others = 1;
            while (true)
            {
                while (others < n && (Knows(possibleCelebrity, others) == false))
                {
                    others++;
                }
                if (others > n - 1)
                {
                    if (Cheak(possibleCelebrity, n))
                    {
                        return possibleCelebrity;
                    }
                    return -1;
                }
                possibleCelebrity = others;
                others++;
            }
        }
        bool Cheak(int possibleCelebrity, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i == possibleCelebrity)
                {
                    continue;
                }
                if (!Knows(i, possibleCelebrity))
                {
                    return false;
                }
                if (Knows(possibleCelebrity, i))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
