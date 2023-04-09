using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _480_MedianSlidingWindow
    {
        int m_balance;
        public double[] MedianSlidingWindow(int[] nums, int k)
        {
            IList<int> bigHeap = new List<int>();//存储较小部分；the head is mid,when they are smaller than mid
            IList<int> smallHeap = new List<int>();//存储较大部分；the head is mid,when they are larger than mid
            m_balance = 0;//balance 大于零则增加small的权重，否则增加big的权重即可
            int index = 0;//维持窗口的位置移动变量。
            int head = 0;//窗口头位置。
            while (index < k)
            {
                InsertNum(bigHeap, smallHeap, index, nums);
                index++;
            }
            double[] res = new double[nums.Length - k + 1];
            Balance(bigHeap, smallHeap, head-1, nums);
            res[0] = FindMid(bigHeap, smallHeap, nums);
            while (index < nums.Length)
            {
                if(bigHeap.Count == 0)
                {
                    m_balance++;
                }
                else if(smallHeap.Count == 0)
                {
                    m_balance--;
                }
                else if(nums[head] > nums[bigHeap[0]])
                {
                    m_balance++;
                }
                else
                {
                    if(nums[head] == nums[bigHeap[0]] && nums[bigHeap[0]] == nums[smallHeap[0]])
                    {
                        if(FindHead(bigHeap, head, 0, nums))
                        {
                            m_balance--;
                        }
                        else
                        {
                            m_balance++;
                        }
                    }
                    m_balance--;
                }
                InsertNum(bigHeap, smallHeap, index, nums);
                index++;
                head++;
                Balance(bigHeap, smallHeap, head-1, nums);
                res[head] = FindMid(bigHeap, smallHeap, nums);
            }
            return res;
        }
        bool FindHead(IList<int> bigHeap, int head, int father, int[] nums)
        {
            if(bigHeap[father] == head)
            {
                return true;
            }
            if(father * 2 + 1 < bigHeap.Count && nums[bigHeap[father*2+1]] == nums[bigHeap[father]] && FindHead(bigHeap, head, father * 2 + 1, nums))
            {
                return true;
            }
            if (father * 2 + 2 < bigHeap.Count && nums[bigHeap[father * 2 + 2]] == nums[bigHeap[father]] && FindHead(bigHeap, head, father * 2 + 2, nums))
            {
                return true;
            }
            return false;
        }
        void DownBigHeap(IList<int> bigHeap, int father, int[] nums)
        {
            int count = bigHeap.Count;
            while (true)
            {
                int leftChild = father * 2 + 1;
                int rightChild = father * 2 + 2;
                int max = father;
                if (leftChild < count && nums[bigHeap[father]] < nums[bigHeap[leftChild]])
                {
                    max = leftChild;
                }
                if (rightChild < count && nums[bigHeap[father]] < nums[bigHeap[rightChild]])
                {
                    max = rightChild;
                }
                if (max == father)
                {
                    break;
                }
                Swap(bigHeap, max, father);
                father = max;
            }
        }
        void DownSmallHeap(IList<int> smallHeap, int father, int[] nums)
        {
            int count = smallHeap.Count;
            while (true)
            {
                int leftChild = father * 2 + 1;
                int rightChild = father * 2 + 2;
                int min = father;
                if (leftChild < count && nums[smallHeap[father]] > nums[smallHeap[leftChild]])
                {
                    min = leftChild;
                }
                if (rightChild < count && nums[smallHeap[father]] > nums[smallHeap[rightChild]])
                {
                    min = rightChild;
                }
                if (min == father)
                {
                    break;
                }
                Swap(smallHeap, min, father);
                father = min;
            }
        }
        void Swap(IList<int> list, int a, int b)
        {
            int temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
        bool Cheak(IList<int> heap, int outNum)
        {
            if(heap.Count == 0)
            {
                return true;
            }
            if (outNum >= heap[0])
            {
                return false;
            }
            return true;
        }
        void Balance(IList<int> bigHeap, IList<int> smallHeap, int outNum, int[] nums)
        {
            while (true)
            {
                if (m_balance < 2 && m_balance > -2 && Cheak(bigHeap, outNum) && Cheak(smallHeap, outNum))
                {
                    return;
                }
                if (m_balance > 1)
                {
                    int temp = bigHeap[0];
                    Swap(bigHeap, 0, bigHeap.Count - 1);
                    bigHeap.RemoveAt(bigHeap.Count - 1);
                    DownBigHeap(bigHeap, 0, nums);
                    smallHeap.Add(temp);
                    UpSmallHeap(smallHeap, smallHeap.Count - 1, nums);
                    m_balance -= 2;
                }
                if (m_balance < -1)
                {
                    int temp = smallHeap[0];
                    Swap(smallHeap, 0, smallHeap.Count - 1);
                    smallHeap.RemoveAt(smallHeap.Count - 1);
                    DownSmallHeap(smallHeap, 0, nums);
                    bigHeap.Add(temp);
                    UpBigHeap(bigHeap, bigHeap.Count - 1, nums);
                    m_balance += 2;
                }
                if (outNum >= bigHeap[0])
                {
                    Swap(bigHeap, 0, bigHeap.Count - 1);
                    bigHeap.RemoveAt(bigHeap.Count - 1);
                    DownBigHeap(bigHeap, 0, nums);
                }
                if (outNum >= smallHeap[0])
                {
                    Swap(smallHeap, 0, smallHeap.Count - 1);
                    smallHeap.RemoveAt(smallHeap.Count - 1);
                    DownSmallHeap(smallHeap, 0, nums);
                }
            }
        }
        double FindMid(IList<int> bigHeap, IList<int> smallHeap, int[] nums)
        {
            if (m_balance == 0)
            {
                return (double)(nums[bigHeap[0]] + nums[smallHeap[0]]) / 2;
            }
            else
            {
                return m_balance < 0 ? nums[smallHeap[0]] : nums[bigHeap[0]];
            }
        }
        void InsertNum(IList<int> bigHeap, IList<int> smallHeap, int num, int[] nums)
        {
            if (bigHeap.Count == 0 || nums[num] < bigHeap[0])
            {
                bigHeap.Add(num);
                UpBigHeap(bigHeap, bigHeap.Count - 1, nums);
                m_balance++;
            }
            else
            {
                smallHeap.Add(num);
                UpSmallHeap(smallHeap, smallHeap.Count - 1, nums);
                m_balance--;
            }
        }
        void UpBigHeap(IList<int> heap, int start, int[] nums)
        {
            while (start > 0)
            {
                int father = (start - 1) / 2;
                if (nums[heap[father]] < nums[heap[start]])
                {
                    Swap(heap, father, start);
                    start = father;
                }
                else
                {
                    break;
                }
            }
        }
        void UpSmallHeap(IList<int> heap, int start, int[] nums)
        {
            while (start > 0)
            {
                int father = (start - 1) / 2;
                if (nums[heap[father]] > nums[heap[start]])
                {
                    Swap(heap, father, start);
                    start = father;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
