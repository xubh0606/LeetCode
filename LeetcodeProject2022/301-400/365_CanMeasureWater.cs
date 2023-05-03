using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _365_CanMeasureWater
    {
        //有两个水壶，容量分别为 jug1Capacity 和 jug2Capacity 升。水的供应是无限的。确定是否有可能使用这两个壶准确得到 targetCapacity 升。
        //如果可以得到 targetCapacity 升水，最后请用以上水壶中的一或两个来盛放取得的 targetCapacity 升水。
        //你可以
        //装满任意一个水壶
        //清空任意一个水壶
        //一个水壶向另外一个水壶倒水，直到装满或者倒空
        HashSet<int> possibleCapacity = new HashSet<int>();
        public bool CanMeasureWater(int jug1Capacity, int jug2Capacity, int targetCapacity)
        {
            possibleCapacity.Add(jug2Capacity);
            possibleCapacity.Add(jug1Capacity + jug2Capacity);
            if (jug2Capacity == jug1Capacity)
            {
                if (possibleCapacity.Contains(targetCapacity))
                {
                    return true;
                }
                return false;
            }
            possibleCapacity.Add(jug1Capacity);
            if (jug2Capacity < jug1Capacity)
            {
                int temp = jug1Capacity;
                jug1Capacity = jug2Capacity;
                jug2Capacity = temp;
            }
            dfs(jug1Capacity, jug2Capacity, jug1Capacity, jug2Capacity);
            return possibleCapacity.Contains(targetCapacity);
        }

        void dfs(int max1, int max2, int cur1, int cur2)
        {
            if (cur1 == 0 && cur2 == 0)
            {
                return;
            }
            if (cur1 == max1)
            {
                dfs(max1, max2, 0, cur2);
            }
            if (cur2 == max2)
            {
                dfs(max1, max2, cur1, 0);
            }
            //大瓶子有水
            if (cur1 == 0)
            {
                int c1 = cur2 - max1;
                if (c1 > 0)
                {
                    if (!possibleCapacity.Contains(c1))
                    {
                        possibleCapacity.Add(c1);
                        dfs(max1, max2, 0, c1);
                    }
                    if (c1 < max1)
                    {
                        if (!possibleCapacity.Contains(c1 + max2))
                        {
                            possibleCapacity.Add(c1 + max2);
                        }
                        dfs(max1, max2, c1, 0);
                    }
                }
                int c2 = cur2 + max1;
                if (c2 > max2)
                {
                    int c4 = c2 - max2;
                    if (!possibleCapacity.Contains(c4))
                    {
                        possibleCapacity.Add(c4);
                        if (!possibleCapacity.Contains(c4 + max2))
                        {
                            possibleCapacity.Add(c4 + max2);
                        }
                        dfs(max1, max2, 0, c4);
                        dfs(max1, max2, c4, 0);
                    }
                }
                else
                {
                    if (!possibleCapacity.Contains(c2))
                    {
                        possibleCapacity.Add(c2);
                        if (!possibleCapacity.Contains(c2 + max1))
                        {
                            possibleCapacity.Add(c2 + max1);
                        }
                        dfs(max1, max2, 0, c2);
                    }
                }
            }

            //2小瓶子有水
            else if (cur2 == 0)
            {
                dfs(max1, max2, 0, cur1);
                int c3 = max2 - cur1;
                if (max2 - cur1 > max1)
                {
                    if (!possibleCapacity.Contains(c3))
                    {
                        possibleCapacity.Add(c3);
                        if (!possibleCapacity.Contains(c3 + max1))
                        {
                            possibleCapacity.Add(c3 + max1);
                        }
                        dfs(max1, max2, 0, c3);
                    }
                }
                else
                {
                    if (!possibleCapacity.Contains(c3))
                    {
                        possibleCapacity.Add(c3);
                        if (!possibleCapacity.Contains(c3 + max2))
                        {
                            possibleCapacity.Add(c3 + max2);
                        }
                        if (!possibleCapacity.Contains(c3 + max1))
                        {
                            possibleCapacity.Add(c3 + max1);
                        }
                        dfs(max1, max2, 0, c3);
                        dfs(max1, max2, c3, 0);
                    }
                }
            }
            return;
        }
    }
}
