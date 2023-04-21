using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022
{
    public static class ChangeStringToCharArr
    {
        public static char[][] GetCharArr(string s)
        {
            IList<char[]> list = new List<char[]>();
            int start = 0;
            while(start < s.Length)
            {
                if(s[start] == '[')
                {
                    IList<char> listC = new List<char>();
                    for (; start < s.Length; start++)
                    {
                        if (s[start] == '[' || s[start] == ' ' || s[start] == ',')
                        {
                            continue;
                        }
                        else if (s[start] == ']') 
                        {
                            break;
                        }
                        else
                        {
                            listC.Add(s[start]);
                        }
                    }
                    list.Add(listC.ToArray());
                }
                start++;
            }
            return list.ToArray();
        }
    }
}
