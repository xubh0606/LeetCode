using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _252_CanAttendMeetings
    {
        public bool CanAttendMeetings(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => a[0] - b[0]);
            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i - 1][1] > intervals[i][0])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
