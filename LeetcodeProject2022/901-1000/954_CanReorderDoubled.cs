using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._901_1000
{
    public class _954_CanReorderDoubled
    {
        public bool CanReorderDoubled(int[] arr)
        {
            //首先0 位是1 位的一半，2 位是3 位的一半。推广来看只要两两可以构成两倍就行了
            //先排序，每次进行翻倍计算，如果存在则继续，否则直接返回false
            Array.Sort(arr);
            Dictionary<int, int> visit = new Dictionary<int, int>();//数字，数量
            int zeroPlace = FindZero(arr);
            //找负数
            for (int i = zeroPlace - 1; i >= 0; i--)
            {
                //两种情况，一个是已经占用，跳过，一个是未被占用，纳入计算
                int num = arr[i];
                if (visit.ContainsKey(num))
                {
                    visit[num]--;
                    if (visit[num] == 0)
                    {
                        visit.Remove(num);
                    }
                }
                else
                {
                    if (visit.ContainsKey(num * 2))
                    {
                        visit[num * 2]++;
                    }
                    else
                    {
                        visit.Add(num * 2, 1);
                    }
                }
            }
            if (visit.Count > 0)
            {
                return false;
            }
            //找0
            int countZero = 0;
            while (zeroPlace < arr.Length)
            {
                if (arr[zeroPlace] != 0)
                {
                    break;
                }
                countZero++;
                zeroPlace++;
            }
            if (countZero % 2 == 1)
            {
                return false;
            }
            //找正数
            for (int i = zeroPlace; i < arr.Length; i++)
            {
                //两种情况，一个是已经占用，跳过，一个是未被占用，纳入计算
                int num = arr[i];
                if (visit.ContainsKey(num))
                {
                    visit[num]--;
                    if (visit[num] == 0)
                    {
                        visit.Remove(num);
                    }
                }
                else
                {
                    if (visit.ContainsKey(num * 2))
                    {
                        visit[num * 2]++;
                    }
                    else
                    {
                        visit.Add(num * 2, 1);
                    }
                }
            }
            return visit.Count == 0;
        }
        int FindZero(int[] arr)
        {
            if (arr[arr.Length - 1] < 0)
            {
                return arr.Length;
            }
            if (arr[0] >= 0)
            {
                return 0;
            }
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return left;
        }
    }
}
