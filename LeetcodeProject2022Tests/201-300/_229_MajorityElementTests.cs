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
    public class _229_MajorityElementTests
    {
        [TestMethod()]
        public void MajorityElementTest()
        {
            int[] nums = new int[] { 3, 2, 3 };
            _229_MajorityElement solution = new _229_MajorityElement();
            IList<int> list = solution.MajorityElement(nums);
            Assert.AreEqual(1, list.Count);
        }
    }
}