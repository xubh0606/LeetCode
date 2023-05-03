using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _149_MaxLine
    {
        public int MaxPoints(int[][] points)
        {
            int max = 1;
            int n = points.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    //遍历
                    if (max > n - i || max > n / 2)
                    {
                        return max;
                    }
                    int count = 2;
                    for (int k = j + 1; k < n; k++)
                    {
                        if (IsInLine(i, j, k, points))
                        {
                            count++;
                        }
                    }
                    if (count > max)
                    {
                        max = count;
                    }
                }
            }
            return max;
        }
        //判断是否共线
        bool IsInLine(int i, int j, int k, int[][] points)
        {
            return (points[k][0] - points[i][0]) * (points[i][1] - points[j][1]) == (points[k][1] - points[i][1]) * (points[i][0] - points[j][0]);
        }
    }
}
