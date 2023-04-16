using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800
{
    public class _765_MinSwapsCouples
    {
        public int MinSwapsCouples(int[] row)
        {
            int n = row.Length;
            int[] map = new int[n];
            for (int i = 0; i < n; i++)
            {
                int cur = row[i];
                int love = (cur % 2 == 1 ? cur - 1 : cur + 1);
                map[love] = i;
            }
            int start = findHeadLover(row, map, 0);
            if (start == n)
            {
                return 0;
            }
            int count = 0;
            while (true)
            {
                count++;
                swap(start, row, map);
                start = findHeadLover(row, map, start + 2);
                if (start == n)
                {
                    return count;
                }

            }
            return count;
        }

        void swap(int start, int[] row, int[] map)
        {
            int cur = start + 1;
            int mapcur = map[cur];
            int love = map[start];
            int place = mapcur % 2 == 0 ? mapcur + 1 : mapcur - 1;
            for (int i = start; i < map.Length; i++)
            {
                if (map[i] == place)
                {
                    map[start] = place;
                    map[i] = love;
                    break;
                }
            }
        }

        int findHeadLover(int[] row, int[] map, int i)
        {
            while (i < row.Length)
            {
                int temp = map[i];
                int love = temp % 2 == 1 ? temp - 1 : temp + 1;
                if (map[i + 1] == love)
                {
                    i += 2;
                }
                else
                {
                    return i;
                }
            }
            return i;
        }
    }
}
