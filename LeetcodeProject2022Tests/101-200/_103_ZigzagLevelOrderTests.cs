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
    public class _103_ZigzagLevelOrderTests
    {
        [TestMethod()]
        public void ZigzagLevelOrderTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 3, 9, 20, -1, -1, 15, 7 });
            _103_ZigzagLevelOrder solution = new _103_ZigzagLevelOrder();
            ChangeStringToList changeL = new ChangeStringToList();
            IList<IList<int>> list = changeL.GetIListIListForInt("[[3],[20,9],[15,7]]");
            IList<IList<int>> listRes = solution.ZigzagLevelOrder(root);
            Assert.IsTrue(CompareToAnother.IsSameListList(list, listRes));
        }
    }
}