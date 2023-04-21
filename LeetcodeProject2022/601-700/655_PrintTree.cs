using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._601_700
{
    public class _655_PrintTree
    {
        public IList<IList<string>> PrintTree(TreeNode root)
        {
            int height = FindHeight(root);
            int colCount = (1 << height) * 2 - 1;
            IList<IList<string>> res = new List<IList<string>>();
            for (int i = 0; i < height + 1; i++)
            {
                res.Add(new List<string>());
                for (int j = 0; j < colCount; j++)
                {
                    res[i].Add("");
                }
            }
            InsertVal(root, 0, colCount / 2, (colCount + 1) / 4, res);
            return res;
        }
        int FindHeight(TreeNode root)
        {
            int max = 0;
            if (root.left != null)
            {
                max = Math.Max(FindHeight(root.left) + 1, max);
            }
            if (root.right != null)
            {
                max = Math.Max(FindHeight(root.right) + 1, max);
            }
            return max;
        }
        void InsertVal(TreeNode root, int row, int col, int move, IList<IList<string>> res)
        {
            res[row][col] = root.val.ToString();
            row++;
            if (root.left != null)
            {
                InsertVal(root.left, row, col - move, move / 2, res);
            }
            if (root.right != null)
            {
                InsertVal(root.right, row, col + move, move / 2, res);
            }
        }
    }
}
