using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _293_GeneratePossibleNextMoves
    {
        public IList<string> GeneratePossibleNextMoves(string currentState)
        {
            StringBuilder sb = new StringBuilder();
            IList<string> result = new List<string>();
            for (int i = 0; i < currentState.Length - 1; i++)
            {
                if (currentState[i] == '+' && currentState[i + 1] == '+')
                {
                    result.Add(GetStr(sb.ToString(), currentState, i + 2));
                }
                sb.Append(currentState[i]);
            }
            return result;
        }
        string GetStr(string str, string currentState, int start)
        {
            str += "--";
            for (int i = start; i < currentState.Length; i++)
            {
                str += currentState[i];
            }
            return str;
        }
    }
}
