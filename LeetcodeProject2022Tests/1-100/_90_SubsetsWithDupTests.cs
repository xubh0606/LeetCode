using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100.Tests
{
    [TestClass()]
    public class _90_SubsetsWithDupTests
    {
        [TestMethod()]
        public void SubsetsWithDupTest()
        {
            int[] nums = new int[] { 1, 2, 2 };
            _90_SubsetsWithDup solution = new _90_SubsetsWithDup();
            Assert.AreEqual(6, solution.SubsetsWithDup(nums).Count);
        }
    }
}