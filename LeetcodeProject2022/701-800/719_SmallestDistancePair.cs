using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800
{
    public class _719_SmallestDistancePair
    {
        int m_heapLength;
        public int SmallestDistancePair(int[] nums, int k)
        {
            Dictionary<int, int> numsCount = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (numsCount.ContainsKey(nums[i]))
                {
                    numsCount[nums[i]]++;
                }
                else
                {
                    numsCount.Add(nums[i], 1);
                }
            }
            int[] c_nums = numsCount.Keys.ToArray();
            Array.Sort(c_nums);
            int sum = 0;
            int len = c_nums.Length;
            for (int i = 0; i < len; i++)
            {
                int count = numsCount[c_nums[i]];
                sum += count * (count - 1);
            }
            sum /= 2;
            if (k <= sum)
            {
                return 0;
            }
            m_heapLength = len - 1;
            int[][] heapArray = new int[m_heapLength][];
            for (int i = 0; i < m_heapLength; i++)
            {
                int[] cur_inf = new int[3];
                cur_inf[1] = c_nums[i];
                cur_inf[0] = c_nums[i + 1] - c_nums[i];
                cur_inf[2] = i + 1;
                heapArray[i] = cur_inf;
            }
            m_heapLength--;
            for (int i = (m_heapLength - 1) / 2; i >= 0; i--)
            {
                HeapDown(heapArray, i);
            }
            int res = 0;
            while (sum < k)
            {
                HeapDown(heapArray, 0);
                res = heapArray[0][0];
                sum += numsCount[heapArray[0][1]] * numsCount[c_nums[heapArray[0][2]]];
                Update(heapArray, c_nums);
            }
            return res;
        }
        void Update(int[][] heapArray, int[] nums)
        {
            int[] arr = heapArray[0];
            arr[2]++;
            if (arr[2] < nums.Length)
            {
                arr[0] = nums[arr[2]] - arr[1];
            }
            else
            {
                Swap(heapArray, 0, m_heapLength);
                m_heapLength--;
            }
        }
        void HeapDown(int[][] heapArray, int father)
        {
            while (father <= m_heapLength)
            {
                int lSon = father * 2 + 1;
                int rSon = father * 2 + 2;
                int min = father;
                if (lSon <= m_heapLength && heapArray[lSon][0] < heapArray[father][0])
                {
                    min = lSon;
                }
                if (rSon <= m_heapLength && heapArray[rSon][0] < heapArray[min][0])
                {
                    min = rSon;
                }
                if (min == father)
                {
                    break;
                }
                Swap(heapArray, father, min);
                father = min;
            }
        }
        void Swap(int[][] heapArray, int a, int b)
        {
            int[] temp = heapArray[a];
            heapArray[a] = heapArray[b];
            heapArray[b] = temp;
        }
    }
}
