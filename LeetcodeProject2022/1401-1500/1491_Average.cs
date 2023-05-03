using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1401_1500
{
    public class _1491_Average
    {
        public double Average(int[] salary)
        {
            int max = salary[0];
            int min = salary[0];
            for (int i = 1; i < salary.Length; i++)
            {
                max = Math.Max(max, salary[i]);
                min = Math.Min(min, salary[i]);
                salary[i] += salary[i - 1];
            }
            return ((double)salary[salary.Length - 1] - max - min) / (salary.Length - 2);
        }
    }
}
