using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _107_LevelOrderBottom
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> res = new List<IList<int>>();
            if (root == null)
            {
                return res;
            }
            Stack<int> count = new Stack<int>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            s.Push(root);
            while (q.Count != 0)
            {
                int c = q.Count;
                for (int i = 0; i < c; i++)
                {
                    TreeNode cur = q.Dequeue();
                    if (cur.right != null)
                    {
                        q.Enqueue(cur.right);
                        s.Push(cur.right);
                    }
                    if (cur.left != null)
                    {
                        q.Enqueue(cur.left);
                        s.Push(cur.left);
                    }
                }
                count.Push(c);
            }
            int level = count.Count;
            while (level > 0)
            {
                int c = count.Pop();
                IList<int> list = new List<int>();
                while (c > 0)
                {
                    list.Add(s.Pop().val);
                    c--;
                }
                res.Add(list);
                level--;
            }
            return res;
        }
    }
}
