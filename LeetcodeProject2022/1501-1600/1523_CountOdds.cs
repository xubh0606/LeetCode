using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600
{
    public class _1523_CountOdds
    {
        public int CountOdds(int low, int high)
        {
            return low % 2 == 1 && high % 2 == 1 ? (high - low + 1) / 2 + 1 : (high - low + 1) / 2 + 0;
        }
    }
}
