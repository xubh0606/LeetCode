using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1101_1200
{
    public  class _1196_MaxNumberOfApples
    {
        public int MaxNumberOfApples(int[] weight)
        {
            //维护一个大根堆，然后每次超重就输出最重那个再试图加入新的即可
            IList<int> heapBigApple = new List<int>();
            int lastHeap = 0;
            int sum = 0;
            int max = 0;
            for (int i = 0; i < weight.Length; i++)
            {
                heapBigApple.Add(weight[i]);
                HeapUp(heapBigApple);
                sum += weight[i];
                if (sum > 5000)
                {
                    sum -= heapBigApple[0];
                    RemoveHead(heapBigApple);
                    lastHeap = heapBigApple.Count;
                }
                max = Math.Max(heapBigApple.Count, max);
            }
            return max;
        }
        void HeapUp(IList<int> heapList)
        {
            int son = heapList.Count - 1;
            while (son > 0)
            {
                int father = (son - 1) / 2;
                if (heapList[father] < heapList[son])
                {
                    Swap(heapList, father, son);
                    son = father;
                }
                else
                {
                    break;
                }
            }
        }
        void RemoveHead(IList<int> heapList)
        {
            Swap(heapList, 0, heapList.Count - 1);
            heapList.RemoveAt(heapList.Count - 1);
            HeapDown(heapList, 0);
        }
        void Swap(IList<int> list, int a, int b)
        {
            int temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
        void HeapDown(IList<int> heapList, int father)
        {
            int len = heapList.Count;
            while (father >= 0)
            {
                int leftSon = father * 2 + 1;
                int rightSon = father * 2 + 2;
                int max = father;
                if (leftSon < len && heapList[leftSon] > heapList[father])
                {
                    max = leftSon;
                }
                if (rightSon < len && heapList[rightSon] > heapList[max])
                {
                    max = rightSon;
                }
                if (max == father)
                {
                    break;
                }
                Swap(heapList, father, max);
                father = max;
            }
        }
    }
}
