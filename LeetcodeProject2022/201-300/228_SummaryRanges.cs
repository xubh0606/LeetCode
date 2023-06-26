using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _228_SummaryRanges
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            IList<string> res = new List<string>();
            if (nums.Length == 0)
            {
                return res;
            }
            int start = nums[0];
            int cur = start;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == cur + 1)
                {
                    cur++;
                }
                else
                {
                    if (cur == start)
                    {
                        res.Add(cur.ToString());
                        start = nums[i];
                        cur = nums[i];
                    }
                    else
                    {
                        res.Add(start.ToString() + "->" + cur.ToString());
                        start = nums[i];
                        cur = nums[i];
                    }
                }
            }
            if (cur == start)
            {
                res.Add(cur.ToString());
            }
            else
            {
                res.Add(start.ToString() + "->" + cur.ToString());
            }
            return res;
        }
    }
}
