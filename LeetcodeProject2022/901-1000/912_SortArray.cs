using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._901_1000
{
    public class _912_SortArray
    {
        public int[] SortArray(int[] nums)
        {
            int n = nums.Length;
            for (int i = (n + 1) / 2; i >= 0; i--)
            {
                heapMax(nums, i, n);
            }
            int k = n;
            while (k > 1)
            {
                swap(nums, 0, k - 1);
                k--;
                heapMax(nums, 0, k);
            }
            return nums;
        }

        void heapMax(int[] nums, int i, int n)
        {
            while (i < n)
            {
                int lSon = i * 2 + 1;
                int rSon = i * 2 + 2;
                int max = i;
                if (lSon < n && nums[lSon] > nums[i])
                {
                    max = lSon;
                }
                if (rSon < n && nums[rSon] > nums[max])
                {
                    max = rSon;
                }
                if (i != max)
                {
                    swap(nums, i, max);
                    i = max;
                }
                else
                {
                    return;
                }
            }
            return;
        }

        void swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
