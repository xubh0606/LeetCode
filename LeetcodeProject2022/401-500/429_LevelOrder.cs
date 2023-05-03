using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _429_LevelOrder
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            IList<IList<int>> res = new List<IList<int>>();
            if (root == null)
            {
                return res;
            }
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            while (q.Count != 0)
            {
                int count = q.Count;
                IList<int> list = new List<int>();
                for (int i = 0; i < count; i++)
                {
                    Node dq = q.Dequeue();
                    list.Add(dq.val);
                    IList<Node> nodes = dq.children;
                    for (int j = 0; j < nodes.Count; j++)
                    {
                        q.Enqueue(nodes[j]);
                    }
                }
                res.Add(list);
            }
            return res;
        }
    }
}
