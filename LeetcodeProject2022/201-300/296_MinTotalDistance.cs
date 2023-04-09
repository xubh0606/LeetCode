using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    //给你一个 m x n  的二进制网格 grid ，其中 1 表示某个朋友的家所处的位置。返回 最小的 总行走距离
    public class _296_MinTotalDistance
    {
        public int MinTotalDistance(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int[] friendRow = new int[m];
            int[] friendCol = new int[n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        friendRow[i]++;
                        friendCol[j]++;
                    }
                }
            }
            return FindMinDistance(friendRow) + FindMinDistance(friendCol);
        }
        int FindMinDistance(int[] friend)
        {
            int[] leftSum = new int[friend.Length];
            int total = 0;
            leftSum[0] = friend[0];
            for (int i = 1; i < friend.Length; i++)
            {
                leftSum[i] = leftSum[i - 1] + friend[i];
                total += i * friend[i];
            }
            int lastTotal = total;
            int index = 0;
            while (index < friend.Length && lastTotal >= total)
            {
                lastTotal = total;
                total += 2 * leftSum[index] - leftSum[friend.Length - 1];
                index++;
            }
            return lastTotal;
        }
    }
}
