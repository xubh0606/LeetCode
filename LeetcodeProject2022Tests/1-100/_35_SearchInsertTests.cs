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
    public class _35_SearchInsertTests
    {
        [TestMethod()]
        public void SearchInsertTest()
        {
            int[] nums = new int[] { 1, 3, 5, 6 };
            int target = 5;
            _35_SearchInsert solution = new _35_SearchInsert();
            Assert.AreEqual(2, solution.SearchInsert(nums, target));
        }
    }
}