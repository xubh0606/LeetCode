using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _361_MaxKilledEnemies
    {
        //给你一个大小为 m x n 的矩阵 grid ，其中每个单元格都放置有一个字符：
        //'W' 表示一堵墙
        //'E' 表示一个敌人
        //'0'（数字 0）表示一个空位
        //返回你使用 一颗炸弹 可以击杀的最大敌人数目。你只能把炸弹放在一个空位里。
        //由于炸弹的威力不足以穿透墙体，炸弹只能击杀同一行和同一列没被墙体挡住的敌人。
        public int MaxKilledEnemies(char[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int[,] mn = new int[m, n];
            int[,] nm = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                int lastWall = -1;
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 'W')
                    {
                        for (int k = j - 1; k > lastWall; k--)
                        {
                            if (grid[i][k] == '0')
                            {
                                mn[i, k] = count;
                            }
                        }
                        lastWall = j;
                        count = 0;
                    }
                    else if (grid[i][j] == 'E')
                    {
                        count++;
                    }
                }
                if (count != 0)
                {
                    for (int k = n - 1; k > lastWall; k--)
                    {
                        if (grid[i][k] == '0')
                        {
                            mn[i, k] = count;
                        }
                    }
                }
            }
            for (int j = 0; j < n; j++)
            {
                int lastWall = -1;
                int count = 0;
                for (int i = 0; i < m; i++)
                {
                    if (grid[i][j] == 'W')
                    {
                        for (int k = i - 1; k > lastWall; k--)
                        {
                            if (grid[k][j] == '0')
                            {
                                nm[k, j] = count;
                            }
                        }
                        lastWall = i;
                        count = 0;
                    }
                    else if (grid[i][j] == 'E')
                    {
                        count++;
                    }
                }
                if (count != 0)
                {
                    for (int k = m - 1; k > lastWall; k--)
                    {
                        if (grid[k][j] == '0')
                        {
                            nm[k, j] = count;
                        }
                    }
                }
            }
            int max = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    max = Math.Max(max, mn[i, j] + nm[i, j]);
                }
            }
            return max;
        }
    }
}
