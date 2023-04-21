using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._901_1000
{
    public class _929_NumUniqueEmails
    {
        public int NumUniqueEmails(string[] emails)
        {
            HashSet<string> diff = new HashSet<string>();
            bool isIgnored = false;
            for (int i = 0; i < emails.Length; i++)
            {
                string s = emails[i];
                StringBuilder sb = new StringBuilder();
                bool isOver = false;
                for (int j = 0; j < s.Length; j++)
                {
                    if (isOver)
                    {
                        sb.Append(s[j]);
                    }
                    else
                    {
                        if(s[j] == '@')
                        {
                            sb.Append('@');
                            isOver = true;
                            continue;
                        }
                        if (!isIgnored)
                        {
                            if(s[j] == '+')
                            {
                                isIgnored = true;
                            }
                            else if(s[j] != '.')
                            {
                                sb.Append(s[j]);
                            }
                        }
                    }
                }
                isIgnored = false;
                diff.Add(sb.ToString());
            }
            return diff.Count;
        }
    }
}
