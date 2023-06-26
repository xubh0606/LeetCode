using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _222_CountNodes
    {
        public int CountNodes(TreeNode root)
        {
            //每层找最右侧点，计算最下层且最右侧的位置并获得总数
            if (root == null)
            {
                return 0;
            }
            if (root.right == null)
            {
                if (root.left == null)
                {
                    return 1;
                }
                return 2;
            }
            int height = 0;
            //起始值为1行，对应节点数为1个
            TreeNode cur = root;
            while (cur.left != null)
            {
                cur = cur.left;
                height++;
            }
            int leftCount = 1 << (height - 1);
            int sum = leftCount * 2;
            //此时已经得到高度，在二分找底层点位置
            while (height > 0)
            {
                cur = root.right;
                int cur_height = height - 1;
                while (cur_height > 0)
                {
                    cur = cur.left;
                    cur_height--;
                }
                if (cur == null)
                {
                    root = root.left;
                }
                else
                {
                    sum += leftCount;
                    root = root.right;
                }
                height--;
                leftCount /= 2;
            }
            return sum;
        }
    }
}
