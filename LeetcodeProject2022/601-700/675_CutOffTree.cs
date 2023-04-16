using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._601_700
{
    public class _675_CutOffTree
    {
        int[][] visit = new int[][] { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { -1, 0 }, new int[] { 1, 0 } };
        public int CutOffTree(IList<IList<int>> forest)
        {
            Dictionary<int, IList<int>> nearByDic = new Dictionary<int, IList<int>>();
            //所有位置对应的周围可行位置（位置为非零）
            IList<int> list = new List<int>();
            //位置的集合，用来sort做排序
            int m = forest.Count;
            int n = forest[0].Count;
            if (forest[0][0] == 0)
            {
                return -1;
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int cur = forest[i][j];
                    if (cur != 0)
                    {
                        list.Add(cur);
                        nearByDic.Add(cur, new List<int>());
                        FindNearBy(i, j, forest, nearByDic[cur], m, n);
                        if (nearByDic[cur].Count == 0)
                        {
                            return -1;
                        }
                    }
                }
            }
            int[] arr = list.ToArray();
            Array.Sort(arr);
            int start = forest[0][0];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int end = arr[i];
                if (end == 1)
                {
                    continue;
                }
                HashSet<int> set = new HashSet<int>();
                int path = bfs(start, end, nearByDic, set);
                //依次运行，输出最小步数，如果无法达到则返回-1；
                if (path == -1)
                {
                    return -1;
                }
                sum += path;
                start = end;
            }
            return sum;
        }

        void FindNearBy(int i, int j, IList<IList<int>> forest, IList<int> nearBy, int m, int n)
        {
            for (int k = 0; k < visit.Length; k++)
            {
                int row = i + visit[k][0];
                int col = j + visit[k][1];
                if (row < 0 || row == m || col < 0 || col == n)
                {
                    continue;
                }
                if (forest[row][col] == 0)
                {
                    continue;
                }
                nearBy.Add(forest[row][col]);
            }
        }

        int bfs(int start, int end, Dictionary<int, IList<int>> nearByDic, HashSet<int> set)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(start);
            int count = 0;
            set.Add(start);
            while (q.Count > 0)
            {
                int c = q.Count;
                for (int i = 0; i < c; i++)
                {
                    int cur = q.Dequeue();
                    if (end == cur)
                    {
                        return count;
                    }
                    IList<int> list = nearByDic[cur];
                    for (int j = 0; j < list.Count; j++)
                    {
                        int nearBy = list[j];
                        if (!set.Contains(nearBy))
                        {
                            set.Add(nearBy);
                            q.Enqueue(nearBy);
                        }
                    }
                }
                count++;
            }
            return -1;
        }
    }
}
