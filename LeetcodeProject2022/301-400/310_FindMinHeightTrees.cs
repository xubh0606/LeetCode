using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _310_FindMinHeightTrees
    {
        //请你找到所有的 最小高度树 并按 任意顺序 返回它们的根节点标签列表。
        public IList<int> FindMinHeightTrees(int n, int[][] edges)
        {
            IList<int> res = new List<int>();
            int[] maxDistance = new int[n];
            IList<IList<int>> nearby = new List<IList<int>>();
            int[] degree = new int[n];
            for (int i = 0; i < n; i++)
            {
                nearby.Add(new List<int>());
            }
            for (int i = 0; i < n - 1; i++)
            {
                degree[edges[i][0]]++;
                degree[edges[i][1]]++;
                nearby[edges[i][0]].Add(edges[i][1]);
                nearby[edges[i][1]].Add(edges[i][0]);
            }
            Queue<int> searchNode = new Queue<int>();
            //找出最外侧的点，其到达另一端的距离必然比更内侧的点远，也就是题意的较大高度
            for (int i = 0; i < n; i++)
            {
                if (nearby[i].Count < 2)
                {
                    searchNode.Enqueue(i);
                }
            }
            int count = searchNode.Count;
            while (count > 0)
            {
                res = new List<int>();
                for (int i = 0; i < count; i++)
                {
                    int cur_node = searchNode.Dequeue();
                    res.Add(cur_node);
                    IList<int> children = nearby[cur_node];
                    for (int j = 0; j < children.Count; j++)
                    {
                        int new_node = children[j];
                        degree[new_node]--;
                        if (degree[new_node] == 1)
                        {
                            searchNode.Enqueue(new_node);
                        }
                    }
                }
                count = searchNode.Count;
                if (count == 0)
                {
                    return res;
                }
            }
            return res;
        }
    }
}
