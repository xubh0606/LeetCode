using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _416_CanPartition
    {
        int m_len;
        int m_sum;
        public bool CanPartition(int[] nums)
        {
            m_len = nums.Length;
            m_sum = 0;
            for (int i = 0; i < m_len; i++)
            {
                m_sum += nums[i];
            }
            if (m_sum % 2 == 1)
            {
                return false;
            }
            int[] total = new int[m_len];
            total[0] = nums[0];
            for (int i = 1; i < m_len; i++)
            {
                total[i] = total[i - 1] + nums[i];
            }
            m_sum /= 2;
            Dictionary<int, HashSet<int>> set = new Dictionary<int, HashSet<int>>();
            return TrackBack(nums, 0, 0, set, total);
        }
        bool TrackBack(int[] nums, int start, int sum, Dictionary<int, HashSet<int>> set, int[] total)
        {
            if (sum == m_sum)
            {
                return true;
            }
            if (start == m_len)
            {
                return false;
            }
            if (sum + total[m_len - 1] - total[start + 1] < m_sum)
            {
                return false;
            }
            if (!set.ContainsKey(start))
            {
                set.Add(start, new HashSet<int>());
                set[start].Add(sum);
                if (TrackBack(nums, start + 1, sum, set, total) ||
                TrackBack(nums, start + 1, sum + nums[start], set, total))
                {
                    return true;
                }
            }
            else if (!set[start].Contains(sum))
            {
                set[start].Add(sum);
                if (TrackBack(nums, start + 1, sum, set, total) ||
                TrackBack(nums, start + 1, sum + nums[start], set, total))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
