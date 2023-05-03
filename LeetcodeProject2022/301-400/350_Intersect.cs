using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _350_Intersect
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            int i = 0;
            int j = 0;
            IList<int> res = new List<int>();
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] == nums2[j])
                {
                    res.Add(nums1[i]);
                    i++;
                    j++;
                }
                else if (nums1[i] < nums2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
            return res.ToArray();
        }
    }
}
