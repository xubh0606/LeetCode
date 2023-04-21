using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _488_FindMinStep
    {
        int minCount = int.MaxValue;
        public int FindMinStep(string board, string hand)
        {
            HashSet<string> set = new HashSet<string>();
            int lenH = hand.Length;
            Queue<string[]> q = new Queue<string[]>();
            q.Enqueue(new string[] { board, hand });
            while (q.Count != 0)
            {
                for (int i = 0; i < q.Count; i++)
                {
                    string[] s = q.Dequeue();
                    string q_board = s[0];
                    string s1 = s[1];
                    for (int j = 0; j < s1.Length; j++)
                    {
                        char insert = s1[j];
                        string new_hand = s1.Remove(j, 1);
                        int count = lenH - new_hand.Length;
                        for (int k = 0; k < q_board.Length; k++)
                        {
                            if (k > 0 && insert == q_board[k - 1]) continue;


                            // 第 3 个剪枝条件: 只在以下两种情况放置新球
                            bool choose = false;

                            //  - 第 1 种情况 : 当前球颜色与后面的球的颜色相同
                            if (k < q_board.Length && q_board[k] == insert)
                            {
                                choose = true;
                            }

                            //  - 第 2 种情况 : 当前后颜色相同且与当前颜色不同时候放置球
                            if (k > 0 && k < q_board.Length && q_board[k - 1] == q_board[k] && q_board[k - 1] != insert)
                            {
                                choose = true;
                            }

                            if (choose)
                            {
                                string new_board = recur(q_board.Substring(0, k) + insert + q_board.Substring(k));
                                if (new_board == "")
                                {
                                    minCount = Math.Min(count, minCount);
                                    continue;
                                }
                                if (new_hand == "")
                                {
                                    continue;
                                }
                                string key = $"{new_board}+{new_hand}";
                                if (!set.Contains(key))
                                {
                                    set.Add(key);
                                    q.Enqueue(new string[] { new_board, new_hand });
                                }
                            }
                        }
                    }
                }
            }
            return minCount == int.MaxValue ? -1 : minCount;
        }

        string recur(string board)
        {
            int len = board.Length;
            for (int l = 0, r = 0; r <= len; r++)
            {
                if (r < len && board[l] == board[r]) continue;
                if (r - l > 2) return recur(board.Substring(0, l) + board.Substring(r));
                else l = r;
            }
            return board;
        }
    }
}
