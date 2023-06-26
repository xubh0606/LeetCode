using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _304_NumMatrix
    {
        //左上角全前缀和
        int[,] m_dp;
        public _304_NumMatrix(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            m_dp = new int[m + 1, n + 1];
            m_dp[1, 1] = matrix[0][0];
            for (int i = 1; i < n; i++)
            {
                m_dp[1, i + 1] = matrix[0][i] + m_dp[1, i];
            }
            for (int i = 1; i < m; i++)
            {
                m_dp[i + 1, 1] = m_dp[i, 1] + matrix[i][0];
                int cur = matrix[i][0];
                for (int j = 1; j < n; j++)
                {
                    cur += matrix[i][j];
                    m_dp[i + 1, j + 1] = cur + m_dp[i, j + 1];
                }
            }
        }


        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            return m_dp[row2 + 1, col2 + 1] + m_dp[row1, col1] - m_dp[row1, col2 + 1] - m_dp[row2 + 1, col1];
        }
    }
}
