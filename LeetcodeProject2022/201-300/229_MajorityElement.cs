using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _229_MajorityElement
    {
        public IList<int> MajorityElement(int[] nums)
        {
            IList<int> res = new List<int>();
            int voter1 = nums[0];
            int j = 1;
            int n = nums.Length;
            while (j < n && nums[j] == voter1)
            {
                j++;
            }
            if (j == n)
            {
                res.Add(voter1);
                return res;
            }
            int voter2 = nums[j];
            int count1 = j;
            int count2 = 1;
            for (int i = j + 1; i < n; i++)
            {
                int t = nums[i];
                if (t == voter1)
                {
                    count1++;
                }
                else if (t == voter2)
                {
                    count2++;
                }
                else
                {
                    if (count1 == 0)
                    {
                        count1 = 1;
                        voter1 = t;
                    }
                    else if (count2 == 0)
                    {
                        count2 = 1;
                        voter2 = t;
                    }
                    else
                    {
                        count2--;
                        count1--;
                    }
                }
            }
            count1 = 0;
            count2 = 0;
            foreach (int num in nums)
            {
                if (voter1 == num) count1++;
                if (voter2 == num) count2++;
            }
            if (count1 > n / 3) res.Add(voter1);
            if (count2 > n / 3) res.Add(voter2);
            return res;
        }
    }
}
