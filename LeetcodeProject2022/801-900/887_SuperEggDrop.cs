using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900
{
    public class _887_SuperEggDrop
    {
        //考虑到最坏情况包括了摔碎和多次测试2种情况，需要分类讨论
        //dp 0位代表蛋的使用数量，1位代表运行次数
        public int SuperEggDrop(int k, int n)
        {
            if (k == 1 || n == 1)
            {
                return n;
            }
            int[,] m_dp = new int[n + 1, k + 1];
            for (int i = 1; i <= k; i++)
            {
                m_dp[1, i] = 1;
            }
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= k; j++)
                {
                    m_dp[i, j] = m_dp[i - 1, j - 1] + m_dp[i - 1, j] + 1;
                }
                if (m_dp[i, k] >= n)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
