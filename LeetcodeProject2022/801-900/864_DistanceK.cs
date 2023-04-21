using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900
{
    public class _863_DistanceK
    {
        Dictionary<int, IList<int>> nearbyNode = new Dictionary<int, IList<int>>();
        public IList<int> DistanceK(TreeNode root, TreeNode target, int k)
        {
            nearbyNode.Add(root.val, new List<int>());
            FindNearby(root);
            HashSet<int> visited = new HashSet<int>();
            visited.Add(target.val);
            Queue<int> curDistanceQ = new Queue<int>();
            curDistanceQ.Enqueue(target.val);
            int count = 1;
            while (count > 0 && k > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    int cur = curDistanceQ.Dequeue();
                    if (nearbyNode.ContainsKey(cur))
                    {
                        IList<int> list = nearbyNode[cur];
                        for (int j = 0; j < list.Count; j++)
                        {
                            if (!visited.Contains(list[j]))
                            {
                                curDistanceQ.Enqueue(list[j]);
                                visited.Add(list[j]);
                            }
                        }
                    }

                }
                k--;
                count = curDistanceQ.Count;
            }
            IList<int> res = new List<int>();
            for (int i = 0; i < count; i++)
            {
                res.Add(curDistanceQ.Dequeue());
            }
            return res;
        }
        void FindNearby(TreeNode root)
        {
            int valRoot = root.val;
            if (root.left != null)
            {
                int valLeft = root.left.val;
                nearbyNode[valRoot].Add(valLeft);
                nearbyNode.Add(valLeft, new List<int>());
                nearbyNode[valLeft].Add(valRoot);
                FindNearby(root.left);
            }
            if (root.right != null)
            {
                int valRight = root.right.val;
                nearbyNode[valRoot].Add(valRight);
                nearbyNode.Add(valRight, new List<int>());
                nearbyNode[valRight].Add(valRoot);
                FindNearby(root.right);
            }
        }
    }
}
