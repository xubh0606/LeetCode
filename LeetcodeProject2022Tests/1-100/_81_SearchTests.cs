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
    public class _81_SearchTests
    {
        [TestMethod()]
        public void SearchTest()
        {
            int[] nums = new int[] { 4,5,6,7,0,1,2};
            int target = 0;
            _81_Search solution = new _81_Search();
            Assert.IsTrue(solution.Search(nums, target));
        }
    }
}