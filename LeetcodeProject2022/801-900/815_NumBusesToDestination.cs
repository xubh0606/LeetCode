using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900
{
    public class _815_NumBusesToDestination
    {
        Dictionary<int, IList<int>> BusToGet;
        bool meet = false;
        public int NumBusesToDestination(int[][] routes, int source, int target)
        {
            if (source == target)
            {
                return 0;
            }
            BusToGet = new Dictionary<int, IList<int>>();
            for (int i = 0; i < routes.Length; i++)
            {
                for (int j = 0; j < routes[i].Length; j++)
                {
                    int sta = routes[i][j];
                    if (BusToGet.ContainsKey(sta))
                    {
                        BusToGet[sta].Add(i);
                    }
                    else
                    {
                        BusToGet.Add(sta, new List<int>());
                        BusToGet[sta].Add(i);
                    }
                }
            }
            HashSet<int> visitedStationR = new HashSet<int>();
            HashSet<int> visitedStationT = new HashSet<int>();
            Queue<int> choicesR = new Queue<int>();
            Queue<int> choicesT = new Queue<int>();
            choicesR.Enqueue(source);
            choicesT.Enqueue(target);
            visitedStationR.Add(source);
            visitedStationT.Add(target);
            int updateRes = 1;
            int count = 1;
            while (updateRes != 0)
            {
                if (choicesT.Count > choicesR.Count)
                {
                    updateRes = update(visitedStationR, visitedStationT, choicesR, routes);
                }
                else
                {
                    updateRes = update(visitedStationT, visitedStationR, choicesT, routes);
                }
                if (meet)
                {
                    return count;
                }
                count++;
            }
            return -1;
        }
        int update(HashSet<int> usingHash, HashSet<int> targetHash, Queue<int> usingQueue, int[][] routes)
        {
            int count = usingQueue.Count;
            for (int i = 0; i < count; i++)
            {
                int cur_sourve = usingQueue.Dequeue();
                if (!BusToGet.ContainsKey(cur_sourve))
                {
                    continue;
                }
                IList<int> buses = BusToGet[cur_sourve];
                for (int j = 0; j < buses.Count; j++)
                {
                    for (int k = 0; k < routes[buses[j]].Length; k++)
                    {
                        int station = routes[buses[j]][k];
                        if (!usingHash.Contains(station))
                        {
                            if (targetHash.Contains(station))
                            {
                                meet = true;
                                return -1;
                            }
                            usingQueue.Enqueue(station);
                            usingHash.Add(station);
                        }
                    }
                }
            }
            count = usingQueue.Count;
            return count;
        }
    }
}
