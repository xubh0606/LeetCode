using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._901_1000
{
    public class _904_TotalFruit
    {
        public int TotalFruit(int[] fruits)
        {
            int max = 0;
            int left = 0;//左侧位置
            int right = 1;//右侧位置
            int count1 = 1;
            int count2 = 0;//两个篮子的各自总数
            int val1 = fruits[0];
            int val2 = -1;//两个篮子对应的类型
            while (right < fruits.Length)
            {
                if (fruits[right] == val1)
                {
                    count1++;
                }
                else if (fruits[right] == val2)
                {
                    count2++;
                }
                else if (val2 == -1)
                {
                    val2 = fruits[right];
                    count2++;
                }
                else
                {
                    max = Math.Max(max, count1 + count2);
                    while (count1 > 0 && count2 > 0)
                    {
                        if (fruits[left] == val1)
                        {
                            count1--;
                        }
                        else
                        {
                            count2--;
                        }
                        left++;
                    }
                    if (count1 == 0)
                    {
                        val1 = fruits[right];
                        count1++;
                    }
                    else
                    {
                        val2 = fruits[right];
                        count2++;
                    }
                }
                right++;
            }
            max = Math.Max(max, count1 + count2);
            return max;
        }
    }
}
