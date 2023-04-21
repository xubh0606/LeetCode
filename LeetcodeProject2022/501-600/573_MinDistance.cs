using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._501_600
{
    public class _573_MinDistance
    {
        public int MinDistance(int height, int width, int[] tree, int[] squirrel, int[][] nuts)
        {
            int sum = 0;
            int min = int.MaxValue;
            for (int i = 0; i < nuts.Length; i++)
            {
                int treeToNut = Math.Abs(nuts[i][0] - tree[0]) + Math.Abs(nuts[i][1] - tree[1]);
                int squirrelToNut = Math.Abs(nuts[i][0] - squirrel[0]) + Math.Abs(nuts[i][1] - squirrel[1]);
                min = Math.Min(min, squirrelToNut - treeToNut);
                sum += treeToNut * 2;
            }
            return sum + min;
        }
    }
}
