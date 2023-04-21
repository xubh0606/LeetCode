using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _219_ContainsNearbyDuplicate
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int cur = nums[i];
                if (dic.ContainsKey(cur))
                {
                    if (Math.Abs(dic[cur] - i) <= k)
                    {
                        return true;
                    }
                    dic[cur] = i;
                }
                else
                {
                    dic.Add(cur, i);
                }
            }
            return false;
        }
    }
}
