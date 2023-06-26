using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _223_ComputeArea
    {
        public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
        {
            //a U b = a + b - (a N b)
            //判断是否存在重叠，如果不存在dx为0，否则dx和dy就是重叠的高和宽
            int dx = 0;
            int dy = 0;
            if (ax1 < bx1)
            {
                if (ax2 > bx1)
                {
                    dx = Math.Min(bx2, ax2) - bx1;
                }
            }
            else
            {
                if (ax1 < bx2)
                {
                    dx = Math.Min(bx2, ax2) - ax1;
                }
            }
            if (ay1 < by1)
            {
                if (ay2 > by1)
                {
                    dy = Math.Min(by2, ay2) - by1;
                }
            }
            else
            {
                if (ay1 < by2)
                {
                    dy = Math.Min(by2, ay2) - ay1;
                }
            }
            return (ax2 - ax1) * (ay2 - ay1) + (bx2 - bx1) * (by2 - by1) - dx * dy;
        }
    }
}
