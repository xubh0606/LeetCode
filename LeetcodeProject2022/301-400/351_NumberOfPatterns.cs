using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _351_NumberOfPatterns
    {
        //我们都知道安卓有个手势解锁的界面，是一个 3 x 3 的点所绘制出来的网格。
        //用户可以设置一个 “解锁模式” ，通过连接特定序列中的点，形成一系列彼此连接的线段，
        //每个线段的端点都是序列中两个连续的点。
        //如果满足以下两个条件，则 k 点序列是有效的解锁模式：
        //解锁模式中的所有点 互不相同 。
        //假如模式中两个连续点的线段需要经过其他点的中心，那么要经过的点 必须提前出现 在序列中（已经经过)，不能跨过任何还未被经过的点。

        int m_count;
        HashSet<int> m_used;
        int m_maxCount;
        int[,] m_notAble;
        public int NumberOfPatterns(int m, int n)
        {
            m_notAble = new int[10, 10];
            m_notAble[1, 3] = 2;
            m_notAble[3, 1] = 2;
            m_notAble[1, 7] = 4;
            m_notAble[7, 1] = 4;
            m_notAble[1, 9] = 5;
            m_notAble[9, 1] = 5;
            m_notAble[2, 8] = 5;
            m_notAble[8, 2] = 5;
            m_notAble[3, 7] = 5;
            m_notAble[7, 3] = 5;
            m_notAble[3, 9] = 6;
            m_notAble[9, 3] = 6;
            m_notAble[4, 6] = 5;
            m_notAble[6, 4] = 5;
            m_notAble[7, 9] = 8;
            m_notAble[9, 7] = 8;
            int[] res1 = new int[n + 1];
            int[] res2 = new int[n + 1];
            int[] res5 = new int[n + 1];
            int res = 0;
            for (int i = 1; i <= n; i++)
            {
                m_count = 0;
                m_used = new HashSet<int>();
                m_used.Add(1);
                m_maxCount = i;
                getCount(1);
                res1[i] = m_count;
            }
            for (int i = 1; i <= n; i++)
            {
                m_count = 0;
                m_used = new HashSet<int>();
                m_used.Add(2);
                m_maxCount = i;
                getCount(2);
                res2[i] = m_count;
            }
            for (int i = 1; i <= n; i++)
            {
                m_count = 0;
                m_used = new HashSet<int>();
                m_maxCount = i;
                m_used.Add(5);
                getCount(5);
                res5[i] = m_count;
            }
            for (int i = m; i <= n; i++)
            {
                res = res + res1[i] * 4 + res2[i] * 4 + res5[i];
            }
            return res;
        }
        void getCount(int lastNum)
        {
            if (m_used.Count == m_maxCount)
            {
                m_count++;
                return;
            }
            for (int i = 1; i < 10; i++)
            {
                if (!m_used.Contains(i))
                {
                    if (m_notAble[lastNum, i] == 0 || m_used.Contains(m_notAble[lastNum, i]))
                    {
                        m_used.Add(i);
                        getCount(i);
                        m_used.Remove(i);
                    }
                }
            }
        }
    }
}
