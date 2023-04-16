using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._801_900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900.Tests
{
    [TestClass()]
    public class _839_NumSimilarGroupsTests
    {
        [TestMethod()]
        public void NumSimilarGroupsTest()
        {
            string[] strs = new string[] { "tars", "rats", "arts", "star" };
            _839_NumSimilarGroups solution = new _839_NumSimilarGroups();
            Assert.AreEqual(2, solution.NumSimilarGroups(strs));
        }
    }
}