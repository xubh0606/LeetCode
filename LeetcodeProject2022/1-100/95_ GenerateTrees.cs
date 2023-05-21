using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _95__GenerateTrees
    {
        //1主流解法很基础，就是基于排除相同答案的回溯和递归
        //2考虑通过旋转节点获得的不同情况
        public IList<TreeNode> GenerateTrees(int n)
        {
            IList<TreeNode> res = new List<TreeNode>();
            //首先将主节点放入，此时已经固定了左右元素的数量与大小
            for (int i = 1; i < n + 1; i++)
            {
                Insert(GetNodeWithHead(1, i, n), res);
            }
            return res;
        }
        void Insert(IList<TreeNode> cur, IList<TreeNode> res)
        {
            foreach (var item in cur)
            {
                res.Add(item);
            }
        }
        IList<TreeNode> GetNodeWithHead(int left, int headVal, int right)
        {
            if (left == right)
            {
                TreeNode head = new TreeNode(headVal);
                IList<TreeNode> list = new List<TreeNode>();
                list.Add(head);
                return list;
            }
            IList<TreeNode> leftNodes = new List<TreeNode>();
            IList<TreeNode> rightNodes = new List<TreeNode>();
            if (headVal > left)
            {
                for (int i = left; i < headVal; i++)
                {
                    Insert(GetNodeWithHead(left, i, headVal - 1), leftNodes);
                }
            }
            if (headVal < right)
            {
                for (int i = headVal + 1; i <= right; i++)
                {
                    Insert(GetNodeWithHead(headVal + 1, i, right), rightNodes);
                }
            }
            return GetTotalHead(headVal, leftNodes, rightNodes);
        }
        IList<TreeNode> GetTotalHead(int head, IList<TreeNode> leftNodes, IList<TreeNode> rightNodes)
        {
            if (leftNodes.Count == 0)
            {
                leftNodes.Add(null);
            }
            if (rightNodes.Count == 0)
            {
                rightNodes.Add(null);
            }
            IList<TreeNode> total = new List<TreeNode>();
            for (int i = 0; i < leftNodes.Count; i++)
            {
                for (int j = 0; j < rightNodes.Count; j++)
                {
                    TreeNode cur = new TreeNode(head);
                    cur.left = Clone(leftNodes[i]);
                    cur.right = Clone(rightNodes[j]);
                    total.Add(cur);
                }
            }
            return total;
        }
        TreeNode Clone(TreeNode node)
        {
            if (node == null)
            {
                return null;
            }
            TreeNode new_node = new TreeNode(node.val);
            if (node.left != null)
            {
                new_node.left = Clone(node.left);
            }
            if (node.right != null)
            {
                new_node.right = Clone(node.right);
            }
            return new_node;
        }
    }
}
