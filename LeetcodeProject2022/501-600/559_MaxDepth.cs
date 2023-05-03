using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._501_600
{
    public class _559_MaxDepth
    {
        public int MaxDepth(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            int count = 0;
            while (q.Count != 0)
            {
                count++;
                int c = q.Count;
                for (int i = 0; i < c; i++)
                {
                    Node n = q.Dequeue();
                    IList<Node> list = n.children;
                    for (int j = 0; j < list.Count; j++)
                    {
                        q.Enqueue(list[j]);
                    }
                }
            }
            return count;
        }
    }
}
