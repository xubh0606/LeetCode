using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _494_FindTargetSumWays
    {
        public int FindTargetSumWays(int[] nums, int target)
        {
            Dictionary<int, int> FromZeroDic = new Dictionary<int, int>();
            Dictionary<int, int> FromTargetDic = new Dictionary<int, int>();
            int countZ = 0;
            int countT = nums.Length - 1;
            FromZeroDic.Add(0, 1);
            FromTargetDic.Add(target - nums[countT], 1);
            if (nums[countT] == 0)
            {
                FromTargetDic[target - nums[countT]]++;
            }
            else
            {
                FromTargetDic.Add(target + nums[countT], 1);
            }
            while (countZ != countT)
            {
                if (FromZeroDic.Count < FromTargetDic.Count)
                {
                    FromZeroDic = Update(FromZeroDic, nums[countZ]);
                    countZ++;
                }
                else
                {
                    countT--;
                    FromTargetDic = Update(FromTargetDic, nums[countT]);
                }
            }
            int sum = 0;
            foreach(int item in FromTargetDic.Keys)
            {
                if (FromZeroDic.ContainsKey(item))
                {
                    sum += FromTargetDic[item] * FromZeroDic[item];
                }
            }
            return sum;
        }
        Dictionary<int, int> Update(Dictionary<int,int> dic, int num)
        {
            Dictionary<int, int> new_dic = new Dictionary<int, int>();
            foreach(int item in dic.Keys)
            {
                int next1 = item + num;
                int next2 = item - num;
                if (!new_dic.ContainsKey(next1))
                {
                    new_dic.Add(next1, dic[item]);
                }
                else
                {
                    new_dic[next1] += dic[item];
                }
                if (!new_dic.ContainsKey(next2))
                {
                    new_dic.Add(next2, dic[item]);
                }
                else
                {
                    new_dic[next2] += dic[item];
                }
            }
            return new_dic;
        }
    }
}
