using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _307_NumArray
    {//按照index 划分，左侧为0 - n/2 右侧为 n/2 - n
        _307_TreeNode m_head;
        int[] m_nums;
        public _307_NumArray(int[] nums)
        {
            m_nums = nums;
            m_head = SetTree(nums, 0, nums.Length - 1);
        }

        _307_TreeNode SetTree(int[] nums, int left, int right)
        {
            _307_TreeNode cur = new _307_TreeNode(left, right);
            if (left == right)
            {
                cur.total = nums[left];
                return cur;
            }
            int mid = left + (right - left) / 2;
            cur.leftChild = SetTree(nums, left, mid);
            cur.rightChild = SetTree(nums, mid + 1, right);
            cur.total = cur.leftChild.total + cur.rightChild.total;
            return cur;
        }

        public void Update(int index, int val)
        {
            //对每个包含此值的加上差值即可
            int change = val - m_nums[index];
            Change(change, index);
            m_nums[index] = val;
        }

        void Change(int change, int index)
        {
            m_head.total += change;
            _307_TreeNode cur = m_head;
            while (cur.leftRange != cur.rightRange)
            {
                if (cur.leftChild.rightRange >= index)
                {
                    cur = cur.leftChild;
                }
                else
                {
                    cur = cur.rightChild;
                }
                cur.total += change;
            }
        }

        public int SumRange(int left, int right)
        {
            return GetTotal(m_head, left, right);
        }
        //此时必然在cur范围内，分类讨论左右两侧总值即可
        int GetTotal(_307_TreeNode cur, int left, int right)
        {
            if (cur.leftRange == cur.rightRange)
            {
                return cur.total;
            }
            int mid = cur.leftChild.rightRange;
            if (mid < left)
            {
                return GetTotal(cur.rightChild, left, right);
            }
            if (mid >= right)
            {
                return GetTotal(cur.leftChild, left, right);
            }
            return GetTotal(cur.leftChild, left, mid) + GetTotal(cur.rightChild, mid + 1, right);
        }
    }
    public class _307_TreeNode
    {
        public int leftRange;
        public int rightRange;
        public _307_TreeNode leftChild;
        public _307_TreeNode rightChild;
        public int total;
        public _307_TreeNode(int left, int right)
        {
            leftRange = left;
            rightRange = right;
            total = 0;
        }
    }
}
