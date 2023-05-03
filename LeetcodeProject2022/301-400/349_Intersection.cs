using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _349_Intersection
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            int[] dp = new int[1001];
            for (int i = 0; i < nums1.Length; i++)
            {
                dp[nums1[i]] = 1;
            }
            HashSet<int> res = new HashSet<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                if (dp[nums2[i]] == 1)
                {
                    if (!res.Contains(nums2[i]))
                    {
                        res.Add(nums2[i]);
                    }
                }
            }
            return res.ToArray();
        }
    }
}
