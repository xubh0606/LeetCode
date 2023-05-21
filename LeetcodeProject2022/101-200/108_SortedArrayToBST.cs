using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _108_SortedArrayToBST
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return GetBST(nums, 0, nums.Length - 1);
        }
        TreeNode GetBST(int[] nums, int left, int right)
        {
            if (left > right)
            {
                return null;
            }
            if (left == right)
            {
                return new TreeNode(nums[left]);
            }
            int mid = left + (right - left) / 2;
            TreeNode cur_head = new TreeNode(nums[mid]);
            cur_head.left = GetBST(nums, left, mid - 1);
            cur_head.right = GetBST(nums, mid + 1, right);
            return cur_head;
        }
    }
}
