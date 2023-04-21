using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _484_FindPermutation
    {
        //由范围 [1,n] 内所有整数组成的 n 个整数的排列 perm 可以表示为长度为 n - 1 的字符串 s ，其中:
        //如果 perm[i] < perm[i + 1] ，那么 s[i] == ' i '
        //如果 perm[i] > perm[i + 1] ，那么 s[i] == 'D' 。
        //给定一个字符串 s ，重构字典序上最小的排列 perm 并返回它。
        public int[] FindPermutation(string s)
        {
            int start = 1;
            int[] nums = new int[s.Length + 1];
            if (s[0] == 'I')
            {
                nums[0] = 1;
                start++;
            }
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == 'I')
                {
                    int index = i;
                    int num = start;
                    while (index >= 0 && nums[index] == 0)
                    {
                        nums[index] = num;
                        num++;
                        index--;
                    }
                    start = num;
                }
            }
            int indexEnd = s.Length;
            while (indexEnd >= 0 && nums[indexEnd] == 0)
            {
                nums[indexEnd] = start;
                start++;
                indexEnd--;
            }
            return nums;
        }
    }
}
