using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1301_1400
{
    public class _1363_LargestMultipleOfThree
    {
        public string LargestMultipleOfThree(int[] digits)
        {
            //已知各位数字全部相加得到三的倍数时本数字也为三的倍数
            //第一种方法先挑选长度最长的可能，如果只有一个则挑选最大排列，否则对每种情况挑选最大排列即可，时间复杂度太高
            //第一步，获得每种数字的个数
            int[] nums = new int[11];
            for (int i = 0; i < digits.Length; i++)
            {
                nums[digits[i]]++;
            }
            int sum = 0;
            for (int i = 1; i < 10; i++)
            {
                sum += nums[i] * i;
            }
            if (sum == 0)
            {
                if (nums[0] == 0)
                {
                    return "";
                }
                return "0";
            }
            if (sum % 3 == 0)
            {
                return GetStr(nums);
            }
            return GetStr(FindNewNums(nums, sum % 3));
        }
        string GetStr(int[] nums)
        {
            //从9数到1，如果为空直接返回空，否则加上0返回
            string s = "";
            for (int i = 9; i > 0; i--)
            {
                if (nums[i] == 0)
                {
                    continue;
                }
                s += GetCur((char)('0' + i), nums[i]);
            }
            if (s != "")
            {
                if (nums[0] != 0)
                {
                    s += GetCur('0', nums[0]);
                }
                return s;
            }
            if (nums[0] != 0)
            {
                return "0";
            }
            return "";
        }
        string GetCur(char c, int count)
        {
            string s = "";
            s += c;
            int len = 1;
            while (len * 2 <= count)
            {
                len *= 2;
                s += s;
            }
            if (len == count)
            {
                return s;
            }
            return s + GetCur(c, count - len);
        }
        //能够成功的原理在于，是1，可以最多通过减少2次3n+2得到，如果是2，也可以最多通过减少2次3n+1得到
        int[] FindNewNums(int[] nums, int sum)
        {
            //原则1，不去除0,3,6,9
            //原则2，每次尽量去除的小，但是不能没有的强行去除
            for (int i = 1; i < 10; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                if (nums[i] > 0 && i % 3 == sum)
                {
                    nums[i]--;
                    return nums;
                }
            }
            for (int i = 1; i < 10; i++)
            {
                if (i % 3 == 0 || nums[i] == 0)
                {
                    continue;
                }
                nums[i]--;
                for (int j = 1; j < 10; j++)
                {
                    if (j % 3 == 0 || nums[j] == 0)
                    {
                        continue;
                    }
                    if ((i + j) % 3 == sum)
                    {
                        nums[j]--;
                        return nums;
                    }
                }
                nums[i]++;
            }
            return new int[10];
        }
    }
}
