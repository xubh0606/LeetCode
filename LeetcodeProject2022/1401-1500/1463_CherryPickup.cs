using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1401_1500
{
    public class _1463_CherryPickup
    {
        int[] m_next = new int[] { -1, 0, 1 };
        int m_len;
        int m_row;
        public int CherryPickup(int[][] grid)
        {
            m_len = grid[0].Length;
            int[,] cur_maxSum = new int[m_len - 1, m_len];//每层都只和下一层有关，所以只需要单层的空间即可
            m_row = grid.Length - 1;
            for (int i = 0; i < m_len - 1; i++)
            {
                for (int j = i + 1; j < m_len; j++)
                {
                    cur_maxSum[i, j] = grid[m_row][i] + grid[m_row][j];//第一层为最底层，只需要添加两个位置的和
                }
            }
            while (m_row > 0)//每层计算。得出结果后向上移动位置直到找出出发点的最大收获
            {
                m_row--;
                cur_maxSum = FindNextLevel(cur_maxSum, grid);
            }
            return cur_maxSum[0, m_len - 1];
        }
        int[,] FindNextLevel(int[,] cur_maxSum, int[][] grid)
        {
            int leftLen = Math.Min(m_len, m_row + 1);//由于不需要超过当前层走不到的位置，可以缩小范围
            int[,] next_maxSum = new int[leftLen, m_len];
            for (int i = 0; i < leftLen; i++)
            {
                for (int j = Math.Max(i + 1, m_len - m_row - 1); j < m_len; j++)
                {
                    //每层2个位置 + 上一层的最好结果
                    //两个机器人落在单个位置的可能性可以被覆盖不影响结果
                    next_maxSum[i, j] = grid[m_row][i] + grid[m_row][j] + GetMax(cur_maxSum, i, j);
                }
            }
            return next_maxSum;
        }
        int GetMax(int[,] cur_maxSum, int left, int right)
        {
            int max = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int cur_left = left + m_next[i];
                    int cur_right = right + m_next[j];
                    if (cur_left >= 0 && cur_left < m_len && cur_right >= 0 && cur_right < m_len && cur_left < cur_right)
                    {
                        max = Math.Max(max, cur_maxSum[cur_left, cur_right]);
                    }
                }
            }
            return max;
        }
    }
}
