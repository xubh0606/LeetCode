using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1601_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_.Tests
{
    [TestClass()]
    public class _0FF043_CBTInserterTests
    {
        [TestMethod()]
        public void _0FF043_CBTInserterTest()
        {
            _0FF043_CBTInserter CBTInserter = new _0FF043_CBTInserter(TreeNode.GetTree(new int[] { 1, 2, 3, 4, 5, 6 }));
            Assert.AreEqual(3, CBTInserter.Insert(7));
            Assert.AreEqual(4, CBTInserter.Insert(8));
            //输入：inputs = ["CBTInserter","insert","insert","get_root"], inputs = [[[1,2,3,4,5,6]],[7],[8],[]]
            //输出：[null,3,4,[1,2,3,4,5,6,7,8]]
        }
    }
}