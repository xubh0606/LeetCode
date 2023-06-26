using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600
{
    //三分法求近似值，条件为凸函数或者凹函数
    //由于答案较为宽泛，所以eps设置在le-5到le-7都可行
    public class _1515_GetMinDistSum
    {
        double eps = 1e-7;
        double min;
        double max;
        public double GetMinDistSum(int[][] positions)
        {
            //收集上下界限
            min = 100;
            max = 0;
            for (int i = 0; i < positions.Length; i++)
            {
                max = Math.Max(max, Math.Max(positions[i][1], positions[i][0]));
                min = Math.Min(min, Math.Min(positions[i][0], positions[i][1]));
            }
            double x = min;
            double y = max;
            while (x - y < eps)
            {
                double ml = x + (y - x) / 3;
                double mr = ml + (y - x) / 3;
                if (Search(ml, positions) < Search(mr, positions))
                {
                    y = mr - eps;
                }
                else
                {
                    x = ml + eps;
                }
            }
            return Search(x, positions);
        }

        double SumSqrt(double centre, double x, int[][] positions)
        {
            double sum = 0;
            for (int i = 0; i < positions.Length; i++)
            {
                double p1 = Math.Abs(positions[i][0] - centre);
                double p2 = Math.Abs(positions[i][1] - x);
                sum += Math.Sqrt(p1 * p1 + p2 * p2);
            }
            return sum;
        }
        public double Search(double x, int[][] pos)
        {
            double l = min, r = max;
            while (r - l > eps)
            {
                double mid = (l + r) / 2;
                double mmid = (mid + r) / 2;
                if (SumSqrt(x, mid, pos) < SumSqrt(x, mmid, pos))
                    r = mmid;
                else l = mid;
            }
            return SumSqrt(x, l, pos);
        }
    }
}
