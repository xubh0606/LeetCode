using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _481_MagicalString
    {
        public int MagicalString(int n)
        {
            if (n < 4)
            {
                return 1;
            }
            bool point = true;
            int index = 2;
            int total = 1;
            StringBuilder sb = new StringBuilder();
            sb.Append("122");
            while (sb.Length < n)
            {
                if (point)
                {
                    if (sb[index] == '1')
                    {
                        sb.Append('1');
                        total++;
                    }
                    else
                    {
                        sb.Append("11");
                        total += 2;
                    }
                    point = false;
                }
                else
                {
                    if (sb[index] == '1')
                    {
                        sb.Append('2');
                    }
                    else
                    {
                        sb.Append("22");
                    }
                    point = true;
                }
                index++;
            }
            if (sb.Length > n && sb[n] == '1')
            {
                return total - 1;
            }
            return total;
        }
    }
}
