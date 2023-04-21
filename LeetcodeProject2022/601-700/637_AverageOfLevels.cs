using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._601_700
{
    public class _637_AverageOfLevels
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            IList<double> res = new List<double>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                int count = q.Count;
                double sum = 0;
                for (int i = 0; i < count; i++)
                {
                    TreeNode node = q.Dequeue();
                    sum += node.val;
                    if (node.left != null)
                    {
                        q.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        q.Enqueue(node.right);
                    }
                }
                res.Add(sum / count);
            }
            return res;
        }
    }
}
