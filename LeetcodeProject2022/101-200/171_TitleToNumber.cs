using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _171_TitleToNumber
    {
        public int TitleToNumber(string columnTitle)
        {
            int cur = 1;
            int sum = 0;
            for (int i = columnTitle.Length - 1; i >= 0; i--)
            {
                sum += (columnTitle[i] - 64) * cur;
                cur *= 26;
            }
            return sum;
        }
    }
}
