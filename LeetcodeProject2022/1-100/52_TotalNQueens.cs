using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _52_TotalNQueens
    {
        IList<IList<string>> res = new List<IList<string>>();
        //通过回溯每一次选取位置，按行进行判断是否能够走通，即可算出总数字。
        public int SolveNQueens(int n)
        {
            int[] nums = new int[n + 1];
            HashSet<int> test1 = new HashSet<int>();
            HashSet<int> test2 = new HashSet<int>();
            IList<int> chessBoard = new List<int>();
            chessBoard.Add(100);
            backtrack(nums, chessBoard, 1, test1, test2);
            return res.Count;
        }

        void backtrack(int[] nums, IList<int> chessBoard, int count, HashSet<int> test1, HashSet<int> test2)
        {
            if (count >= nums.Length)
            {
                IList<string> list = new List<string>();
                for (int a = 1; a < chessBoard.Count; a++)
                {
                    string temp = "";
                    for (int b = 1; b < chessBoard.Count; b++)
                    {
                        if (b == chessBoard[a])
                        {
                            temp += 'Q';
                        }
                        else
                        {
                            temp += '.';
                        }
                    }
                    list.Add(temp);
                }
                res.Add(list);
                return;
            }
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    continue;
                }
                int t1 = count - i;
                int t2 = count + i;
                if (test1.Contains(t1) || test2.Contains(t2))
                {
                    continue;
                }
                nums[i]++;
                chessBoard.Add(i);
                test1.Add(t1);
                test2.Add(t2);
                backtrack(nums, chessBoard, count + 1, test1, test2);
                nums[i]--;
                chessBoard.RemoveAt(chessBoard.Count - 1);
                test1.Remove(t1);
                test2.Remove(t2);
            }
        }
    }
}
