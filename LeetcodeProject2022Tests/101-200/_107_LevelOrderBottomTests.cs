using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._101_200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200.Tests
{
    [TestClass()]
    public class _107_LevelOrderBottomTests
    {
        [TestMethod()]
        public void LevelOrderBottomTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 3, 9, 20, -1, -1, 15, 7 });
            _107_LevelOrderBottom solution = new _107_LevelOrderBottom();
            ChangeStringToList changeL = new ChangeStringToList();
            IList<IList<int>> list = changeL.GetIListIListForInt("[[15,7],[9,20],[3]]");
            Assert.IsTrue(CompareToAnother.IsSameListList(list, solution.LevelOrderBottom(root)));
        }
    }
}