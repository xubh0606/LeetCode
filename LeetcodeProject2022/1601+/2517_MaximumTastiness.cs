using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_
{
    public class _2517_MaximumTastiness
    {
        //正常二分，每次考虑中间那个数值。
        public int MaximumTastiness(int[] price, int k)
        {
            Array.Sort(price);
            int len = price.Length;
            int right = price[len - 1] - price[0];
            int left = 0;
            while (left < right)
            {
                int mid = left + (right - left + 1) / 2;
                if (Cheak(mid, price, k))
                {
                    left = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return right;
        }
        bool Cheak(int num, int[] price, int k)
        {
            int count = 1;
            int lastPrice = price[0];
            for (int i = 1; i < price.Length; i++)
            {
                if (price[i] - lastPrice >= num)
                {
                    count++;
                    lastPrice = price[i];
                }
            }
            return count >= k;
        }


        //    Dictionary<_2517_Node, int> m_nodePlace;
        //    public int MaximumTastiness(int[] price, int k)
        //    {
        //        //先对排序后的数组建立连续性，此时得到 k = len 时的甜蜜度
        //        //建立链表和最小堆heap，每次选取堆头的输出，直到heap 的大小等于k
        //        Array.Sort(price);
        //        //每个node对应长度为len 的价格差，当选取后合并左右两个较小的那个
        //        _2517_Node head = new _2517_Node(int.MaxValue);
        //        int len = price.Length;
        //        _2517_Node cur = head;
        //        IList<_2517_Node> heapList = new List<_2517_Node>();
        //        m_nodePlace = new Dictionary<_2517_Node, int>();
        //        for (int i = 0; i < len - 1; i++)
        //        {
        //            _2517_Node new_node = new _2517_Node(price[i + 1] - price[i]);
        //            m_nodePlace.Add(new_node, i);
        //            cur.next = new_node;
        //            new_node.prev = cur;
        //            cur = new_node;
        //            heapList.Add(new_node);
        //            HeapUp(heapList);
        //        }
        //        _2517_Node tail = new _2517_Node(int.MaxValue);
        //        m_nodePlace.Add(head, -1);
        //        m_nodePlace.Add(tail, -1);
        //        cur.next = tail;
        //        tail.prev = cur;
        //        for (int i = 0; i < len - k; i++)
        //        {
        //            Pull(heapList);
        //        }
        //        return heapList[0].len;
        //    }

        //    void Swap(IList<_2517_Node> heapList, int a, int b)
        //    {
        //        _2517_Node temp = heapList[a];
        //        heapList[a] = heapList[b];
        //        heapList[b] = temp;
        //        m_nodePlace[heapList[a]] = a;
        //        m_nodePlace[heapList[b]] = b;
        //    }

        //    void HeapUp(IList<_2517_Node> heapList)
        //    {
        //        int cur = heapList.Count - 1;
        //        while (cur > 0)
        //        {
        //            int father = (cur - 1) / 2;
        //            if (heapList[father].len > heapList[cur].len)
        //            {
        //                Swap(heapList, father, cur);
        //                cur = father;
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }
        //    }

        //    void Pull(IList<_2517_Node> heapList)
        //    {
        //        //每次消除对应node 再合并len 到附近node 内
        //        _2517_Node remove_node = heapList[0];
        //        _2517_Node p = remove_node.prev;
        //        _2517_Node n = remove_node.next;
        //        if (p.len < n.len)
        //        {
        //            p.len += remove_node.len;
        //            HeapDown(heapList, m_nodePlace[p]);
        //        }
        //        else
        //        {
        //            n.len += remove_node.len;
        //            HeapDown(heapList, m_nodePlace[n]);
        //        }
        //        p.next = n;
        //        n.prev = p;
        //        int tail = heapList.Count - 1;
        //        Swap(heapList, 0, tail);
        //        heapList.RemoveAt(tail);
        //        HeapDown(heapList, 0);
        //    }

        //    void HeapDown(IList<_2517_Node> heapList, int father)
        //    {
        //        if (father == -1)
        //        {
        //            return;
        //        }
        //        int count = heapList.Count;
        //        while (father < count)
        //        {
        //            int lSon = father * 2 + 1;
        //            int rSon = father * 2 + 2;
        //            int min = father;
        //            if (lSon < count && heapList[lSon].len < heapList[father].len)
        //            {
        //                min = lSon;
        //            }
        //            if (rSon < count && heapList[rSon].len < heapList[min].len)
        //            {
        //                min = rSon;
        //            }
        //            if (min == father)
        //            {
        //                break;
        //            }
        //            Swap(heapList, min, father);
        //            father = min;
        //        }
        //    }
    }
    //public class _2517_Node
    //{
    //    public int len;
    //    public _2517_Node prev;
    //    public _2517_Node next;
    //    public _2517_Node(int val)
    //    {
    //        this.len = val;
    //        prev = null;
    //        next = null;
    //    }
    //}
}
