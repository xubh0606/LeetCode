using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_
{
    public class _2031_SubarraysWithMoreZerosThanOnes
    {//1多于0等同于前缀和大于0,但是要先将数组转化为1和-1组成的数组
        public int SubarraysWithMoreZerosThanOnes(int[] nums)
        {
            //最大为全1；最小为全-1
            int n = nums.Length;
            int[] TotalSums = new int[2 * n + 1];
            TotalSums[n] = 1;
            //初始在n位置(总和为0)建立起始位置
            int res = 0;
            int cur_sum = 0;//记录当前的前缀和即可
            int position = n;//当前位置。每次移动时调整总和的位置并且改变前缀和
            for (int i = 0; i < n; i++)
            {
                if (nums[i] > 0)
                {
                    cur_sum += TotalSums[position];
                    position++;
                    TotalSums[position]++;
                    //想象前缀和的场景：无论是否为0都可计入，首先添加当前位置，然后移动到加1的位置，再增加总量
                }
                else
                {
                    position--;
                    cur_sum -= TotalSums[position];
                    TotalSums[position]++;
                    //此时需要先下移动，因为自己一旦是刚刚好达到0，则不能计入，然后添加当前位置，再增加总量
                }
                res += cur_sum;
                res %= 1000000007;
            }
            return res;
        }
    }
}
