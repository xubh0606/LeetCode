using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _530_GetMinimumDifference
    {
        int cur = -100000;
        int dif;
        int min = int.MaxValue;
        public int GetMinimumDifference(TreeNode root)
        {
            GetNumbers(root);
            return min;
        }
        void GetNumbers(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            GetNumbers(root.left);
            dif = root.val - cur;
            cur = root.val;
            min = Math.Min(min, dif);
            GetNumbers(root.right);
        }
    }
}
