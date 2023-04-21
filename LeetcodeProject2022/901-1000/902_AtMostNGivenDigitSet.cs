using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._901_1000
{
    public class _902_AtMostNGivenDigitSet
    {
        public int AtMostNGivenDigitSet(string[] digits, int n)
        {
            int divider = 10;
            int count = 1;
            while (divider < n)
            {
                divider *= 10;
                count++;
            }
            if (divider != n)
            {
                divider /= 10;
                count--;
            }
            int[] numsInRamge = new int[count+1];//某位数字的全排列，比如100以内是66,67,76,77
            numsInRamge[0] = 1;
            for (int i = 1; i <= count; i++)
            {
                numsInRamge[i] = numsInRamge[i - 1] * digits.Length;
            }
            int sum = 0;
            for(int i = 1; i <= count; i++)
            {
                sum += numsInRamge[i];
            }
            //至此获得了前10、100.1000个数内有多少个符合条件的数字
            //后续可以通过每次去掉最高位来求总数
            bool isEnd = false;//如果当前位上的数字不在表内（或者是0）就结束运转，小于divider的数字就为结果
            while (n > 10)
            {
                if (n >= divider)
                {
                    int numsUsing = 0;
                    int firstNum = n / divider;
                    n %= divider;
                    isEnd = true;
                    for (int i = 0; i < digits.Length; i++)
                    {
                        if (digits[i][0] - '0' >= firstNum)//判断首位数字的情况
                        {
                            if(digits[i][0] - '0' == firstNum)
                            {
                                isEnd = false;
                            }
                            break;
                        }
                        numsUsing++;
                    }
                    sum += numsUsing * numsInRamge[count];//当前位数和是：小于divider的全部有效数字+小于首字母的所有此位数排列
                }
                else
                {
                    isEnd = true;
                }
                divider /= 10;
                count--;
                if (divider == 1 || isEnd)
                {
                    break;
                }
            }
            if (!isEnd)
            {
                for (int i = 0; i < digits.Length; i++)
                {
                    if (digits[i][0] - '0' > n)
                    {
                        break;
                    }
                    sum++;
                }
            }
            return sum;
        }
    }
}
