using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _164_MaximumGap
    {//基数排序
        public int MaximumGap(int[] nums)
        {
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                max = Math.Max(max, nums[i]);
            }
            //对数字的位数进行排序
            int level = ("" + max).Length;
            int[,] bucket = new int[10, nums.Length];//记录每次调用后的排序
            int[] bucketElements = new int[10];//记录对应的数字个数
            int n = 1;
            for (int i = 0; i < level; i++)
            {
                //每次按照对应的位数上的数字进行排列
                for (int j = 0; j < nums.Length; j++)
                {
                    int digit = nums[j] / n % 10;
                    bucket[digit, bucketElements[digit]] = nums[j];
                    bucketElements[digit]++;
                }
                int index = 0;
                for (int k = 0; k < 10; k++)
                {
                    if (bucketElements[k] != 0)
                    {
                        for (int m = 0; m < bucketElements[k]; m++)
                        {
                            nums[index] = bucket[k, m];
                            index++;
                        }
                        bucketElements[k] = 0;
                    }
                }
                n *= 10;
            }
            max = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                max = Math.Max(max, nums[i] - nums[i - 1]);
            }
            return max;
        }
    }
}
