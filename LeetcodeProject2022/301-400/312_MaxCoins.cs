using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _312_MaxCoins
    {
        //现在要求你戳破所有的气球。戳破第 i 个气球，
        //你可以获得 nums[i - 1] * nums[i] * nums[i + 1] 枚硬币。 
        //这里的 i - 1 和 i + 1 代表和 i 相邻的两个气球的序号
        //如果 i - 1或 i + 1 超出了数组的边界，那么就当它是一个数字为 1 的气球。

        public int MaxCoins(int[] nums)
        {
            int len = nums.Length + 2;
            int[] new_nums = new int[len];
            int[,] dp = new int[len, len];
            new_nums[0] = 1;
            new_nums[len - 1] = 1;
            for (int i = 0; i < len - 2; i++)
            {
                new_nums[i + 1] = nums[i];
            }
            for (int count = 2; count < len; count++)
            {
                for (int i = 0; i < len - count; i++)
                {
                    int end = i + count;
                    for (int j = i + 1; j < i + count; j++)
                    {
                        dp[i, end] = Math.Max(dp[i, end], dp[i, j] + new_nums[i] * new_nums[j] * new_nums[end] + dp[j, end]);
                    }
                }
            }
            return dp[0, len - 1];
        }
    }
}
