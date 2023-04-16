using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800
{
    public class _789_EscapeGhosts
    {
        public bool EscapeGhosts(int[][] ghosts, int[] target)
        {
            int targetDis = Math.Abs(target[0]) + Math.Abs(target[1]);
            for (int i = 0; i < ghosts.Length; i++)
            {
                int ghostsDis = Math.Abs(ghosts[i][0] - target[0]) + Math.Abs(ghosts[i][1] - target[1]);
                if (ghostsDis <= targetDis)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
