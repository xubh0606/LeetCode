using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _340_LengthOfLongestSubstringKDistinct
    {
        //给你一个字符串 s 和一个整数 k ，请你找出 至多 包含 k 个 不同 字符的最长子串，并返回该子串的长度。
        public int LengthOfLongestSubstringKDistinct(string s, int k)
        {
            int count = 0;
            int max = 0;
            int[] charCount = new int[128];
            int left = -1;
            int right = 0;
            while (right < s.Length)
            {
                int char_right = s[right];
                if (charCount[char_right] == 0)
                {
                    count++;
                }
                charCount[char_right]++;
                while (count > k)
                {
                    left++;
                    int char_left = s[left];
                    if (charCount[char_left] == 1)
                    {
                        count--;
                    }
                    charCount[char_left]--;
                }
                max = Math.Max(max, right - left);
                right++;
            }
            return max;
        }
    }
}
