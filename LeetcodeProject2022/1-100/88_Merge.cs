using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _88_Merge
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int cur = m + n - 1;
            m--;
            n--;
            while (m >= 0 && n >= 0)
            {
                if (nums1[m] > nums2[n])
                {
                    nums1[cur] = nums1[m];
                    m--;
                }
                else
                {
                    nums1[cur] = nums2[n];
                    n--;
                }
                cur--;
            }
            while (n >= 0)
            {
                nums1[cur] = nums2[n];
                n--;
                cur--;
            }
        }
    }
}
