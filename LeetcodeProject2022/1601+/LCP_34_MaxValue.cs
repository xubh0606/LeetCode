using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_
{
    public  class LCP_34_MaxValue
    {
        public int MaxValue(TreeNode root, int k)
        {
            IList<int> rootList = GetMaxValue(root, k);
            return GetMax(rootList);
        }

        IList<int> GetMaxValue(TreeNode root, int k)
        {
            IList<int> res = new List<int>();
            if (root.left == null && root.right == null)
            {
                res.Add(0);
                res.Add(root.val);
                return res;
            }
            IList<int> l;
            IList<int> r;
            if (root.left != null)
            {
                l = GetMaxValue(root.left, k);
            }
            else
            {
                l = new List<int>();
                l.Add(0);
            }
            if (root.right != null)
            {
                r = GetMaxValue(root.right, k);
            }
            else
            {
                r = new List<int>();
                r.Add(0);
            }
            int maxL = GetMax(l);
            int maxR = GetMax(r);
            res.Add(maxL + maxR);
            res.Add(root.val + l[0] + r[0]);
            for (int i = 1; i < Math.Min(k, l.Count + r.Count - 1); i++)
            {
                int max = 0;
                for (int j = 0; j <= i; j++)
                {
                    if (l.Count > j && r.Count > i - j)
                    {
                        max = Math.Max(max, root.val + l[j] + r[i - j]);
                    }
                }
                res.Add(max);
            }
            return res;
        }
        int GetMax(IList<int> list)
        {
            int max = 0;
            for (int i = 0; i < list.Count; i++)
            {
                max = Math.Max(max, list[i]);
            }
            return max;
        }
    }
}
