using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._401_500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500.Tests
{
    [TestClass()]
    public class _529_UpdateBoardTests
    {
        [TestMethod()]
        public void UpdateBoardTest()
        {
            char[][] board = ChangeStringToCharArr.GetCharArr("[[ E ,  E ,  E ,  E ,  E ],[ E , E , M , E , E ],[ E , E , E , E , E ],[ E , E , E , E , E ]]");
            int[] click = new int[] { 3, 0 };
            _529_UpdateBoard solution = new _529_UpdateBoard();
            //输出：[["B","1","E","1","B"],["B","1","M","1","B"],["B","1","1","1","B"],["B","B","B","B","B"]]
            char[][] res = solution.UpdateBoard(board, click);
            Assert.AreEqual(1, res[0][1]);
        }
    }
}