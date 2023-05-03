using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _314_VerticalOrder
    {
        int maxCount = 0;
        int count = 0;
        public IList<IList<int>> VerticalOrder(TreeNode root)
        {
            IList<IList<int>> res = new List<IList<int>>();
            if (root == null)
            {
                return res;
            }
            GetCount(root);
            int[,] nodes = new int[maxCount, 2];
            Queue<TreeNode> trees = new Queue<TreeNode>();
            Queue<int> t = new Queue<int>();
            t.Enqueue(0);
            trees.Enqueue(root);
            while (trees.Count != 0)
            {
                TreeNode temp = trees.Dequeue();
                int co = t.Dequeue();
                rename(temp, nodes, co);
                if (temp.left != null)
                {
                    trees.Enqueue(temp.left);
                    t.Enqueue(co - 1);
                }
                if (temp.right != null)
                {
                    trees.Enqueue(temp.right);
                    t.Enqueue(co + 1);
                }
            }
            HashSet<int> column = new HashSet<int>();
            IList<int> columnList = new List<int>();
            for (int i = 0; i < maxCount; i++)
            {
                int c = nodes[i, 1];
                if (!column.Contains(c))
                {
                    column.Add(c);
                    columnList.Add(c);
                }
            }
            int[] columnArray = columnList.ToArray();
            Array.Sort(columnArray);
            int j = 0;
            while (j < columnArray.Length)
            {
                int k = columnArray[j];
                IList<int> temp = new List<int>();
                for (int m = 0; m < maxCount; m++)
                {
                    if (nodes[m, 1] == k)
                    {
                        temp.Add(nodes[m, 0]);
                    }
                }
                res.Add(temp);
                j++;
            }
            return res;
        }
        void rename(TreeNode root, int[,] nodes, int column)
        {
            nodes[count, 0] = root.val;
            nodes[count, 1] = column;
            count++;
        }
        void GetCount(TreeNode root)
        {
            maxCount++;
            if (root.left != null)
            {
                GetCount(root.left);
            }
            if (root.right != null)
            {
                GetCount(root.right);
            }
        }
    }
}
