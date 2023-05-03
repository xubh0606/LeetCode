using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600
{
    public class _1514_MaxProbability
    {
        //优化后
        public double MaxProbability(int n, int[][] edges, double[] succProb, int start, int end)
        {
            double[] prob = new double[n];//从start 到任何一点的当前prob
            IList<IList<Tuple<int, double>>> map = new List<IList<Tuple<int, double>>>();
            //点与点之间的概率。tuple：1前端点，2末端id，3 概率
            IList<Tuple<double, int>> heapStartToNode = new List<Tuple<double, int>>();//目前概率，id
            for (int i = 0; i < n; i++)
            {
                map.Add(new List<Tuple<int, double>>());
            }
            for (int i = 0; i < edges.Length; i++)
            {
                map[edges[i][0]].Add(new Tuple<int, double>(edges[i][1], succProb[i]));
                map[edges[i][1]].Add(new Tuple<int, double>(edges[i][0], succProb[i]));
            }
            prob[start] = 1;
            heapStartToNode.Add(new Tuple<double, int>(1, start));
            int count = heapStartToNode.Count;
            while (count > 0)
            {
                //如果没找到则count归零，输出0
                //如果heap最大堆的顶端是end，则输出end，否则继续更新所有可能的更小路径
                double possible = heapStartToNode[0].Item1;
                int cur_start = heapStartToNode[0].Item2;
                if (cur_start == end)
                {
                    return possible;
                }
                Swap(heapStartToNode, 0, count - 1);
                heapStartToNode.RemoveAt(count - 1);
                HeapDown(heapStartToNode);
                IList<Tuple<int, double>> list = map[cur_start];
                for (int i = 0; i < list.Count; i++)
                {
                    int indexToUpdate = list[i].Item1;
                    double thePossible = list[i].Item2;
                    double new_possible = possible * thePossible;
                    if (new_possible > prob[indexToUpdate])
                    {
                        prob[indexToUpdate] = new_possible;
                        heapStartToNode.Add(new Tuple<double, int>(new_possible, indexToUpdate));
                        HeapUp(heapStartToNode);
                    }
                }
                count = heapStartToNode.Count;
            }
            return 0;
        }
        void HeapUp(IList<Tuple<double, int>> heapList)
        {
            int start = heapList.Count - 1;
            while (start != 0)
            {
                int father = (start - 1) / 2;
                if (heapList[start].Item1 > heapList[father].Item1)
                {
                    Swap(heapList, start, father);
                    start = father;
                }
                else
                {
                    break;
                }
            }
        }
        //维护最大堆
        void HeapDown(IList<Tuple<double, int>> heapList)
        {
            int father = 0;
            while (father < heapList.Count)
            {
                int child1 = father * 2 + 1;
                int child2 = father * 2 + 2;
                int max = father;
                if (child1 < heapList.Count && heapList[child1].Item1 > heapList[father].Item1)
                {
                    max = child1;
                }
                if (child2 < heapList.Count && heapList[child2].Item1 > heapList[max].Item1)
                {
                    max = child2;
                }
                if (max == father)
                {
                    break;
                }
                Swap(heapList, father, max);
                father = max;
            }
        }
        void Swap(IList<Tuple<double, int>> heapList, int a, int b)
        {
            if (a == b)
            {
                return;
            }
            Tuple<double, int> temp = heapList[a];
            heapList[a] = heapList[b];
            heapList[b] = temp;
        }
        //优化前
        //public double MaxProbability(int n, int[][] edges, double[] succProb, int start, int end)
        //{
        //    double[] prob = new double[n];//从start 到任何一点的当前prob
        //    IList<IList<Tuple<int, double>>> map = new List<IList<Tuple<int, double>>>();
        //    //点与点之间的概率。tuple：1前端点，2末端id，3 概率
        //    IList<Tuple<double, int>> heapStartToNode = new List<Tuple<double, int>>();//目前概率，id
        //    for (int i = 0; i < n; i++)
        //    {
        //        map.Add(new List<Tuple<int, double>>());
        //    }
        //    for (int i = 0; i < edges.Length; i++)
        //    {
        //        if (edges[i][0] == start)
        //        {
        //            heapStartToNode.Add(new Tuple<double, int>(succProb[i], edges[i][1]));
        //            prob[edges[i][1]] = succProb[i];
        //        }
        //        else
        //        {
        //            map[edges[i][0]].Add(new Tuple<int, double>(edges[i][1], succProb[i]));
        //        }
        //        if (edges[i][1] == start)
        //        {
        //            heapStartToNode.Add(new Tuple<double, int>(succProb[i], edges[i][0]));
        //            prob[edges[i][0]] = heapStartToNode.Count - 1;
        //        }
        //        else
        //        {
        //            map[edges[i][1]].Add(new Tuple<int, double>(edges[i][0], succProb[i]));
        //        }
        //    }
        //    prob[start] = 1;
        //    int count = heapStartToNode.Count;
        //    Heap(heapStartToNode);
        //    while (count > 0)
        //    {
        //        //如果没找到则count归零，输出0
        //        //如果heap最大堆的顶端是end，则输出end，否则继续更新所有可能的更小路径
        //        double possible = heapStartToNode[0].Item1;
        //        int cur_start = heapStartToNode[0].Item2;
        //        if(prob[cur_start] > possible)
        //        {
        //            continue;
        //        }
        //        if (cur_start == end)
        //        {
        //            return possible;
        //        }
        //        Swap(heapStartToNode, 0, count - 1);
        //        heapStartToNode.RemoveAt(count - 1);
        //        IList<Tuple<int, double>> list = map[cur_start];
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            int indexToUpdate = list[i].Item1;
        //            double thePossible = list[i].Item2;
        //            double new_possible = possible * thePossible;
        //            if(new_possible > prob[indexToUpdate])
        //            {
        //                prob[indexToUpdate] = new_possible;
        //                heapStartToNode.Add(new Tuple<double, int>(new_possible, indexToUpdate));
        //            }
        //        }
        //        Heap(heapStartToNode);
        //        count = heapStartToNode.Count;
        //    }
        //    return 0;
        //}
        //void Heap(IList<Tuple<double, int>> heapList)
        //{
        //    for (int i = heapList.Count / 2 - 1; i >= 0; i--)
        //    {
        //        HeapUp(heapList, i);
        //    }
        //}
        ////维护最大堆
        //void HeapUp(IList<Tuple<double, int>> heapList, int father)
        //{
        //    int child1 = father * 2 + 1;
        //    int child2 = father * 2 + 2;
        //    int max = father;
        //    if (child1 < heapList.Count && heapList[child1].Item1 > heapList[father].Item1)
        //    {
        //        max = child1;
        //    }
        //    if (child2 < heapList.Count && heapList[child2].Item1 > heapList[max].Item1)
        //    {
        //        max = child2;
        //    }
        //    if (max != father)
        //    {
        //        Swap(heapList, father, max);
        //    }
        //}
        //void Swap(IList<Tuple<double, int>> heapList, int a, int b)
        //{
        //    Tuple<double, int> temp = heapList[a];
        //    heapList[a] = heapList[b];
        //    heapList[b] = temp;
        //}
    }
}
