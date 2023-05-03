using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1101_1200
{
    public class _1109_CorpFlightBookings
    {
        public int[] CorpFlightBookings(int[][] bookings, int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < bookings.Length; i++)
            {
                arr[bookings[i][0] - 1] += bookings[i][2];
                if (bookings[i][1] < n)
                {
                    arr[bookings[i][1]] -= bookings[i][2];
                }
            }
            for (int i = 1; i < n; i++)
            {
                arr[i] += arr[i - 1];
            }
            return arr;
        }
    }
}
