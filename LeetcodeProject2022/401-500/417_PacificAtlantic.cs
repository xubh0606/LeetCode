using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _417_PacificAtlantic
    {
        int[][] m_visit = new int[][] { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { -1, 0 }, new int[] { 1, 0 } };
        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            int m = heights.Length;
            int n = heights[0].Length;
            bool[,] pacificWay = new bool[m, n];
            bool[,] atlanticWay = new bool[m, n];
            for (int j = 0; j < n; j++)
            {
                if (pacificWay[0, j])
                {
                    continue;
                }
                pacificWay[0, j] = true;
                Dfs(pacificWay, heights, 0, j);
            }
            for (int i = 1; i < m; i++)
            {
                if (pacificWay[i, 0])
                {
                    continue;
                }
                pacificWay[i, 0] = true;
                Dfs(pacificWay, heights, i, 0);
            }
            IList<IList<int>> res = new List<IList<int>>();
            for (int j = 0; j < n; j++)
            {
                if (atlanticWay[m - 1, j])
                {
                    continue;
                }
                atlanticWay[m - 1, j] = true;
                if (pacificWay[m - 1, j])
                {
                    IList<int> list = new List<int>();
                    list.Add(m - 1);
                    list.Add(j);
                    res.Add(list);
                }
                Dfs(atlanticWay, heights, m - 1, j, res);
            }
            for (int i = 0; i < m - 1; i++)
            {
                if (atlanticWay[i, n - 1])
                {
                    continue;
                }
                atlanticWay[i, n - 1] = true;
                if (pacificWay[i, n - 1])
                {
                    IList<int> list = new List<int>();
                    list.Add(i);
                    list.Add(n - 1);
                    res.Add(list);
                }
                Dfs(atlanticWay, heights, i, n - 1, res);
            }
            return res;
        }
        void Dfs(bool[,] OceanWay, int[][] heights, int row, int col)
        {
            for (int i = 0; i < 4; i++)
            {
                int new_row = row + m_visit[i][0];
                int nwe_col = col + m_visit[i][1];
                if (new_row < 0 || new_row >= heights.Length || nwe_col < 0 || nwe_col >= heights[0].Length)
                {
                    continue;
                }
                if (OceanWay[new_row, nwe_col] || heights[row][col] > heights[new_row][nwe_col])
                {
                    continue;
                }
                OceanWay[new_row, nwe_col] = true;
                Dfs(OceanWay, heights, new_row, nwe_col);
            }
        }
        void Dfs(bool[,] OceanWay, int[][] heights, int row, int col, IList<IList<int>> res)
        {
            for (int i = 0; i < 4; i++)
            {
                int new_row = row + m_visit[i][0];
                int nwe_col = col + m_visit[i][1];
                if (new_row < 0 || new_row >= heights.Length || nwe_col < 0 || nwe_col >= heights[0].Length)
                {
                    continue;
                }
                if (OceanWay[new_row, nwe_col] || heights[row][col] > heights[new_row][nwe_col])
                {
                    continue;
                }
                OceanWay[new_row, nwe_col] = true;
                IList<int> list = new List<int>();
                list.Add(new_row);
                list.Add(nwe_col);
                res.Add(list);
                Dfs(OceanWay, heights, new_row, nwe_col);
            }
        }
    }
}
