using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _246_IsStrobogrammatic
    {
        public bool IsStrobogrammatic(string num)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            dic.Add('1', '1');
            dic.Add('6', '9');
            dic.Add('9', '6');
            dic.Add('0', '0');
            dic.Add('8', '8');
            int left = 0;
            int right = num.Length - 1;
            while (left <= right)
            {
                if (dic.ContainsKey(num[left]))
                {
                    if ((dic[num[left]] != num[right]))
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
