using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _187_FindRepeatedDnaSequences
    {
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            IList<string> list = new List<string>();
            if (s.Length < 10)
            {
                return list;
            }
            HashSet<string> FoundDNA = new HashSet<string>();
            HashSet<string> used = new HashSet<string>();
            StringBuilder s1 = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                s1.Append(s[i]);
            }
            FoundDNA.Add(s1.ToString());
            for (int i = 10; i < s.Length; i++)
            {
                s1.Remove(0, 1);
                s1.Append(s[i]);
                string s2 = s1.ToString();
                if (FoundDNA.Contains(s2))
                {
                    if (!used.Contains(s2))
                    {
                        list.Add(s2);
                        used.Add(s2);
                    }
                }
                else
                {
                    FoundDNA.Add(s2);
                }
            }
            return list;
        }
    }
}
