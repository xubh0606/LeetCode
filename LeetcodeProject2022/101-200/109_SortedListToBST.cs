using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _109_SortedListToBST
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            IList<int> list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }
            return GetBST(list, 0, list.Count - 1);
        }
        TreeNode GetBST(IList<int> nums, int left, int right)
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
