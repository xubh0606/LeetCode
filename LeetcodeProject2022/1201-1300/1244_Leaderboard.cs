using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1201_1300
{
    public class _1244_Leaderboard
    {//思路分为2步：
     //1.建立hash用来o(1)存储和增删
     //2.找到第k个元素来O(n)计算总和
        Random m_random;
        Dictionary<int, int> m_playerScore;
        public _1244_Leaderboard()
        {
            m_random = new Random();
            m_playerScore = new Dictionary<int, int>();
        }

        public void AddScore(int playerId, int score)
        {
            if (m_playerScore.ContainsKey(playerId))
            {
                m_playerScore[playerId] += score;
            }
            else
            {
                m_playerScore.Add(playerId, score);
            }
        }

        public int Top(int K)
        {
            int count = 0;
            IList<int> list_score = m_playerScore.Values.ToList();
            int target = FindKthLargest(list_score, K);
            int sum = 0;
            for (int i = 0; i < list_score.Count; i++)
            {
                if (list_score[i] > target)
                {
                    sum += list_score[i];
                    count++;
                }
            }
            sum += (K - count) * target;
            return sum;
        }

        public void Reset(int playerId)
        {
            m_playerScore.Remove(playerId);
        }
        int FindKthLargest(IList<int> nums, int k)
        {
            int len = nums.Count;
            return FindK(nums, 0, len, len - k);
        }
        int FindK(IList<int> nums, int left, int right, int k)
        {
            if (right == left + 1)
            {
                return nums[left];
            }
            if (right == left + 2)
            {
                if (k == left)
                {
                    if (nums[left] > nums[left + 1])
                    {
                        return nums[left + 1];
                    }
                    return nums[left];
                }
                else
                {
                    if (nums[left] > nums[left + 1])
                    {
                        return nums[left];
                    }
                    return nums[left + 1];
                }
            }
            int lastLeft = left;
            int p = m_random.Next(left, right);
            int center = nums[p];
            Swap(nums, p, right - 1);
            p = right - 1;
            right -= 2;
            while (left < right)
            {
                if (nums[left] < center)
                {
                    left++;
                    continue;
                }
                if (nums[right] > center)
                {
                    right--;
                    continue;
                }
                Swap(nums, left, right);
                left++;
                right--;
            }
            if (nums[left] < center)
            {
                left++;
            }
            Swap(nums, left, p);
            if (left == k)
            {
                return nums[left];
            }
            if (left > k)
            {
                return FindK(nums, lastLeft, left, k);
            }
            else
            {
                return FindK(nums, left + 1, p + 1, k);
            }
        }
        void Swap(IList<int> nums, int a, int b)
        {
            int temp = nums[a];
            nums[a] = nums[b];
            nums[b] = temp;
        }
    }
}
