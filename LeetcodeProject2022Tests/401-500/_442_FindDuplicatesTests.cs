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
    public class _442_FindDuplicatesTests
    {
        [TestMethod()]
        public void FindDuplicatesTest()
        {
            int[] nums = new int[] {4, 3, 2, 7, 8, 2, 3, 1};
            _442_FindDuplicates solution = new _442_FindDuplicates();
            Assert.AreEqual(2, solution.FindDuplicates(nums));
        }
    }
}