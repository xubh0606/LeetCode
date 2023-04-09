using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _347_TopKFrequent
    {
        //分治
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> allNumOccur = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (allNumOccur.ContainsKey(nums[i]))
                {
                    allNumOccur[nums[i]]++;
                }
                else
                {
                    allNumOccur.Add(nums[i], 1);
                }
            }
            IList<int> list = new List<int>();
            foreach(int item in allNumOccur.Keys)
            {
                list.Add(item);
            }
            FindKFrequent(allNumOccur, list, 0, allNumOccur.Keys.Count-1);
            int[] res = new int[k];
            for (int i = 0; i < k; i++)
            {
                res[i] = list[i];
            }
            return res;
        }
        void FindKFrequent(Dictionary<int, int> allNumOccur, IList<int> keys, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            FindKFrequent(allNumOccur, keys, left, (left + right) / 2);
            FindKFrequent(allNumOccur, keys, (left + right) / 2 + 1, right);
            IList<int> new_list = new List<int>();
            int i = left;
            int j = (left + right) / 2 + 1;
            while (i <= (left + right) / 2 && j <= right)
            {
                if (allNumOccur[keys[i]] > allNumOccur[keys[j]])
                {
                    new_list.Add(keys[i]);
                    i++;
                }
                else
                {
                    new_list.Add(keys[j]);
                    j++;
                }
            }
            while (i <= (left + right) / 2)
            {
                    new_list.Add(keys[i]);
                    i++;
            }
            while (j <= right)
            {
                    new_list.Add(keys[j]);
                    j++;
            }
            i = 0;
            while(left <= right)
            {
                keys[left] = new_list[i];
                left++;
                i++;
            }
        }
    }
}
