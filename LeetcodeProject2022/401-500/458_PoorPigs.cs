using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _458_PoorPigs
    {
        public int PoorPigs(int buckets, int minutesToDie, int minutesToTest)
        {
            if (buckets == 1)
            {
                return 0;
            }
            int maxTimes = minutesToTest / minutesToDie + 1;
            int pigs = 1;
            int maxBackets = maxTimes;
            while (maxBackets < buckets)
            {
                maxBackets *= maxTimes;
                pigs++;
            }
            return pigs;
        }
    }
}
