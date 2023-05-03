using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._601_700
{
    public class _654_ConstructMaximumBinaryTree
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            TreeNode head = new TreeNode(nums[0]);
            for (int i = 1; i < nums.Length; i++)
            {
                TreeNode cur_node = new TreeNode(nums[i]);
                if (nums[i] > head.val)
                {
                    cur_node.left = head;
                    head = cur_node;
                }
                else
                {
                    TreeNode cur_head = head;
                    while (cur_head.right != null && cur_head.right.val > nums[i])
                    {
                        cur_head = cur_head.right;
                    }
                    cur_node.left = cur_head.right;
                    cur_head.right = cur_node;
                }
            }
            return head;
        }
    }
}
