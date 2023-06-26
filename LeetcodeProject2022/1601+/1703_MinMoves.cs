using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_
{
    public class _1703_MinMoves
    {
        //移动应该遵循的原则：每次移动都是01交换，每次单个1都是为了移动到某个区域内，每次先移动靠近的，再动远处的
        public int MinMoves(int[] nums, int k)
        {
            if (k == 1)
            {
                return 0;
            }
            //考虑使用滑动窗口，因为每次必然是相近的进行聚合
            //此时问题转换成小规模问题：某区域内聚合需要的最短距离
            int right = 0;
            int count = 0;
            int distance = 0;
            //到下一个点的位置一定是选择中位数的点
            //提前选取中心点，并计算完成总距离
            Queue<int> leftPoint = new Queue<int>();
            Queue<int> midPoint = new Queue<int>();
            //计算中位数左侧数量
            int maxLeft = k % 2 == 0 ? k / 2 : k / 2 + 1;
            while (count < maxLeft)
            {
                if (nums[right] == 1)
                {
                    leftPoint.Enqueue(right);
                    count++;
                }
                else
                {
                    distance += count;
                }
                right++;
            }
            midPoint.Enqueue(right - 1);
            while (count < k)
            {
                if (nums[right] == 1)
                {
                    leftPoint.Enqueue(right);
                    midPoint.Enqueue(right);
                    count++;
                }
                right++;
            }
            count = 1;
            int index = right - 2;
            //计算中位数点右侧总距离
            while (count < k / 2 + 1)
            {
                if (nums[index] == 1)
                {
                    count++;
                }
                else
                {
                    distance += count;
                }
                index--;
            }
            int min = distance;
            if (k % 2 == 0)
            {
                midPoint.Dequeue();
                while (right < nums.Length)
                {
                    if (nums[right] == 1)
                    {
                        leftPoint.Enqueue(right);
                        midPoint.Enqueue(right);
                        //获取更新后的距离总值
                        distance = Update(distance, leftPoint.Dequeue(), midPoint.Dequeue(), right);
                        min = Math.Min(distance, min);
                    }
                    right++;
                }
            }
            else
            {
                while (right < nums.Length)
                {
                    if (nums[right] == 1)
                    {
                        leftPoint.Enqueue(right);
                        midPoint.Enqueue(right);
                        //获取更新后的距离总值
                        distance = Update(distance, leftPoint.Dequeue(), midPoint.Dequeue(), midPoint.Peek(), right);
                        min = Math.Min(distance, min);
                    }
                    right++;
                }
            }
            return min;
        }
        //由于中位数可以平移只需要计算一次
        int Update(int distance, int left, int mid, int right)
        {
            return distance - mid * 2 + left + right;
        }
        //对奇数k需要计算两次中点情况
        int Update(int distance, int left, int mid1, int mid2, int right)
        {
            return distance + left - mid1 - mid2 + right;
        }
    }
}
