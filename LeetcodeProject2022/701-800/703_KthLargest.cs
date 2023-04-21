using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800
{
    public class _703_KthLargest
    {
        int[] KthLargestNums = new int[1];
        int n = 0;
        public _703_KthLargest(int k, int[] nums)
        {
            n = nums.Length;
            KthLargestNums = new int[k];
            Array.Sort(nums);
            KthLargestNums[0] = int.MinValue;
            if (n >= k)
            {
                for (int i = k - 1; i >= 0; i--)
                {
                    KthLargestNums[i] = nums[n - k + i];
                }
            }
            else
            {
                for (int i = k - 1; i >= 1; i--)
                {
                    KthLargestNums[i] = nums[n - k + i];
                }
            }
            for (int j = (k + 1) / 2; j >= 0; j--)
            {
                heap(KthLargestNums, j, k);
            }
        }

        public int Add(int val)
        {
            if (val > KthLargestNums[0])
            {
                KthLargestNums[0] = val;
            }
            heap(KthLargestNums, 0, KthLargestNums.Length);
            return KthLargestNums[0];
        }

        void heap(int[] nums, int i, int n)
        {
            while (i < n)
            {
                int lSon = i * 2 + 1;
                int rSon = i * 2 + 2;
                int min = i;
                if (lSon < n && nums[i] > nums[lSon])
                {
                    min = lSon;
                }
                if (rSon < n && nums[min] > nums[rSon])
                {
                    min = rSon;
                }
                if (min != i)
                {
                    swapInHeap(KthLargestNums, i, min);
                    i = min;
                }
                else
                {
                    return;
                }
            }
            return;
        }

        void swapInHeap(int[] nums, int i, int j)
        {
            if (i >= nums.Length || j >= nums.Length)
            {
                return;
            }
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
            return;
        }
    }
}
