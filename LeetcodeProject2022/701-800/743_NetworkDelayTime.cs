using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800
{
    public class _743_NetworkDelayTime
    {
        int[] shortestDelay = new int[101];
        public int NetworkDelayTime(int[][] times, int n, int k)
        {
            for (int i = 1; i <= n; i++)
            {
                shortestDelay[i] = -1;
            }
            shortestDelay[k] = 0;
            dfs(times, k, new HashSet<int>());
            int max = 0;
            for (int j = 1; j <= n; j++)
            {
                if (j != k && shortestDelay[j] == -1)
                {
                    return -1;
                }
                if (shortestDelay[j] > max)
                {
                    max = shortestDelay[j];
                }
            }
            return max;
        }
        void dfs(int[][] times, int start, HashSet<int> nodePath)
        {
            for (int i = 0; i < times.Length; i++)
            {
                if (times[i][0] == start)
                {
                    if (shortestDelay[times[i][1]] == -1 || shortestDelay[times[i][1]] > shortestDelay[start] + times[i][2])
                    {
                        if (nodePath.Contains(times[i][1]))
                        {
                            continue;
                        }
                        nodePath.Add(times[i][1]);
                        shortestDelay[times[i][1]] = shortestDelay[start] + times[i][2];
                        dfs(times, times[i][1], nodePath);
                        nodePath.Remove(times[i][1]);
                    }
                }
            }
        }
    }
}
