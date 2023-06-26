using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._201_300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300.Tests
{
    [TestClass()]
    public class _297_CodecTreeSerializeTests
    {
        [TestMethod()]
        public void serializeTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 1, 2, 3, -1, -1, 4, 5 });
            _297_CodecTreeSerialize solution = new _297_CodecTreeSerialize();
            Assert.AreEqual(10, solution.serialize(root).Length);
        }

        [TestMethod()]
        public void deserializeTest()
        {
            Assert.Fail();
        }
    }
}