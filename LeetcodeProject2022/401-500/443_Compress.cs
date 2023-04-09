using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _443_Compress
    {
        public int Compress(char[] chars)
        {
            int start = 1;
            char cur = chars[0];
            int total = 1;
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] == chars[i - 1])
                {
                    total++;
                }
                else
                {
                    if (total != 1)
                    {
                        string numStr = total.ToString();
                        for (int j = 0; j < numStr.Length; j++)
                        {
                            chars[start] = numStr[j];
                            start++;
                        }
                    }
                    chars[start] = chars[i];
                    start++;
                    cur = chars[i];
                    total = 1;
                }
            }
            if (total != 1)
            {
                string numStr = total.ToString();
                for (int j = 0; j < numStr.Length; j++)
                {
                    chars[start] = numStr[j];
                    start++;
                }
            }
            return start;
        }
    }
}
