using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._601_700
{
    public class _662_WidthOfBinaryTree
    {
        public int WidthOfBinaryTree(TreeNode root)
        {
            if (root.left == null && root.right == null)
            {
                return 1;
            }
            Queue<TreeNode> q = new Queue<TreeNode>();
            Queue<int> qWight = new Queue<int>();
            q.Enqueue(root);
            qWight.Enqueue(1);
            int maxWidth = 1;
            while (q.Count != 0)
            {
                int c = q.Count;
                int first = 0;
                int end = 0;
                for (int i = 0; i < c; i++)
                {
                    TreeNode node = q.Dequeue();
                    int cur = qWight.Dequeue();
                    if (first == 0)
                    {
                        first = cur;
                        end = first;
                    }
                    else
                    {
                        end = cur;
                    }
                    if (node.left != null)
                    {
                        q.Enqueue(node.left);
                        qWight.Enqueue(cur * 2 - 1);
                    }
                    if (node.right != null)
                    {
                        q.Enqueue(node.right);
                        qWight.Enqueue(cur * 2);
                    }
                }
                maxWidth = Math.Max(maxWidth, end - first + 1);
            }
            return maxWidth;
        }
    }
}
