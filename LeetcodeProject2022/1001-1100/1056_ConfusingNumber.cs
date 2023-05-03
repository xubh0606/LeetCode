using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1001_1100
{
    public class _1056_ConfusingNumber
    {
        public bool ConfusingNumber(int n)
        {
            IList<int> num = new List<int>();
            while (n >= 10)
            {
                num.Add(n % 10);
                n /= 10;
            }
            num.Add(n);
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i] == 2 || num[i] == 3 || num[i] == 4 || num[i] == 5 || num[i] == 7)
                {
                    return false;
                }
            }
            for (int i = 0; i < num.Count / 2 + 1; i++)
            {
                if (num[i] == 6)
                {
                    if (num[num.Count - i - 1] != 9)
                    {
                        return true;
                    }
                }
                else if (num[i] == 9)
                {
                    if (num[num.Count - i - 1] != 6)
                    {
                        return true;
                    }
                }
                else if (num[i] == 8)
                {
                    if (num[num.Count - i - 1] != 8)
                    {
                        return true;
                    }
                }
                else if (num[i] == 1)
                {
                    if (num[num.Count - i - 1] != 1)
                    {
                        return true;
                    }
                }
                else if (num[i] == 0)
                {
                    if (num[num.Count - i - 1] != 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
