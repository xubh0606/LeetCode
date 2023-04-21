using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1101_1200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1101_1200.Tests
{
    [TestClass()]
    public class _1145_BtreeGameWinningMoveTests
    {
        [TestMethod()]
        public void BtreeGameWinningMoveTest()
        {
            TreeNode root = new TreeNode(0);
            _1145_BtreeGameWinningMove solution = new _1145_BtreeGameWinningMove();
            Assert.IsFalse(solution.BtreeGameWinningMove(root, 5, 1));
        }
    }
}