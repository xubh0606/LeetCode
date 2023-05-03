using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _446_NumberOfArithmeticSlices
    {
        //第一种想法是形成以某个点为起点，且等待下一个符合数字的集合，难度有点大
        //另一个是以当期值为终点的等差数列
        public int NumberOfArithmeticSlices(int[] nums)
        {
            int len = nums.Length;
            int sum = 0;
            Dictionary<long, int>[] dic = new Dictionary<long, int>[len];
            dic[0] = new Dictionary<long, int>();
            //外层索引：起点的索引，内层Key：距离，即等差的差值，val：前面的总数。
            for (int i = 1; i < len; i++)
            {
                dic[i] = new Dictionary<long, int>();
                for (int j = 0; j < i; j++)
                {
                    long sub = (long)nums[i] - nums[j];
                    int result = 0;
                    if (dic[j].ContainsKey(sub))
                    {
                        result = dic[j][sub];
                    }
                    sum += result;
                    if (dic[i].ContainsKey(sub))
                    {
                        dic[i][sub] += result + 1;
                    }
                    else
                    {
                        dic[i][sub] = result + 1;
                    }
                }
            }
            return sum;
        }
    }
}
