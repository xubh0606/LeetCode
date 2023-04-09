using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _217_ContainsDuplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums == null)
            {
                return false;
            }
            HashSet<int> set = new HashSet<int>();
            foreach (var x in nums)
            {
                if (!set.Add(x)) return true;
            }
            return false;
        }
    }
}
