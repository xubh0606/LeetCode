using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800
{
    public class _787_FindCheapestPrice
    {
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
        {
            int[,] grid = new int[n, n];
            int inf = int.MaxValue / 2;
            //建图
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    grid[i, j] = inf;
                }
                grid[i, i] = 0;
            }
            for (int i = 0; i < flights.Length; i++)
            {
                grid[flights[i][0], flights[i][1]] = flights[i][2];
            }
            int[] dist = new int[n];
            for (int i = 0; i < n; i++)
            {
                dist[i] = inf;
            }
            dist[src] = 0;
            for (int i = 0; i <= k; i++)
            {
                int[] clone = (int[])dist.Clone();
                for (int j = 0; j < n; j++)
                {
                    for (int m = 0; m < n; m++)
                    {
                        dist[m] = Math.Min(dist[m], grid[j, m] + clone[j]);
                    }
                }
            }
            if (dist[dst] == inf)
            {
                return -1;
            }
            return dist[dst];
        }
    }
}
