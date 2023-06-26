using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _239_MaxSlidingWindow
    {
        //队列O(n)， 堆O(logn*n)
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            int end = 0;
            int start = 0;
            Dictionary<int, int> m_out = new Dictionary<int, int>();
            IList<int> heap = new List<int>();
            while (end < k)
            {
                heap.Add(nums[end]);
                end++;
                HeapUp(heap);
            }
            int[] res = new int[nums.Length - k + 1];
            res[0] = heap[0];
            while (end < nums.Length)
            {
                int outNum = nums[start];
                start++;
                if (m_out.ContainsKey(outNum))
                {
                    m_out[outNum]++;
                }
                else
                {
                    m_out.Add(outNum, 1);
                }
                heap.Add(nums[end]);
                end++;
                HeapUp(heap);
                while (m_out.ContainsKey(heap[0]) && m_out[heap[0]] > 0)
                {
                    m_out[heap[0]]--;
                    Swap(heap, 0, heap.Count - 1);
                    heap.RemoveAt(heap.Count - 1);
                    HeapDown(heap);
                }
                res[start] = heap[0];
            }
            return res;
        }
        void HeapUp(IList<int> bigHeap)
        {
            int cur = bigHeap.Count - 1;
            while (cur > 0)
            {
                int father = (cur - 1) / 2;
                if (bigHeap[father] < bigHeap[cur])
                {
                    Swap(bigHeap, father, cur);
                    cur = father;
                }
                else
                {
                    return;
                }
            }
        }
        void HeapDown(IList<int> bigHeap)
        {
            int father = 0;
            while (father < bigHeap.Count)
            {
                int lSon = father * 2 + 1;
                int rSon = father * 2 + 2;
                int max = father;
                if (lSon < bigHeap.Count && bigHeap[lSon] > bigHeap[father])
                {
                    max = lSon;
                }
                if (rSon < bigHeap.Count && bigHeap[rSon] > bigHeap[max])
                {
                    max = rSon;
                }
                if (max == father)
                {
                    break;
                }
                Swap(bigHeap, father, max);
                father = max;
            }
        }
        void Swap(IList<int> list, int a, int b)
        {
            int temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
    }
}
