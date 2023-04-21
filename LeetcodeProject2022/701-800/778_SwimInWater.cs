using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800
{
    public class _778_SwimInWater
    {
        int[][] visit = new int[][] { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { -1, 0 } };
        public int SwimInWater(int[][] grid)
        {
            int n = grid.Length;
            return SearchMid(0, n * n, grid);
        }
        int SearchMid(int left, int right, int[][] grid)
        {
            int n = grid.Length - 1;
            while (left < right)
            {
                HashSet<int> set = new HashSet<int>();
                int mid = left + (right - left) / 2;
                if (dfs(grid, mid, 0, 0, n, set))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return right;
        }
        bool dfs(int[][] grid, int level, int row, int col, int n, HashSet<int> set)
        {
            if (row < 0 || row > n || col < 0 || col > n)
            {
                return false;
            }
            int code = row * 100 + col;
            if (set.Contains(code))
            {
                return false;
            }
            set.Add(code);
            if (grid[row][col] > level)
            {
                return false;
            }
            if (row == n && col == n)
            {
                return true;
            }
            bool canGet = false;
            for (int i = 0; i < 4; i++)
            {
                bool bi = dfs(grid, level, row + visit[i][0], col + visit[i][1], n, set);
                if (bi)
                {
                    canGet = true;
                }
            }
            return canGet;
        }
    }
}
