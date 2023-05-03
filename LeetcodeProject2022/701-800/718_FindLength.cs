using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800
{
    public class _718_FindLength
    {
        public int FindLength(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;
            int max = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        if (i > 0 && j > 0 && nums1[i - 1] == nums2[j - 1])
                        {
                            continue;
                        }
                        max = Math.Max(max, Find(nums1, nums2, i + 1, j + 1));
                    }
                }
            }
            return max;
        }
        int Find(int[] nums1, int[] nums2, int i, int j)
        {
            int count = 1;
            while (i < nums1.Length && j < nums2.Length && nums1[i] == nums2[j])
            {
                i++;
                j++;
                count++;
            }
            return count;
        }
    }
}
