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
    public class _238_ProductExceptSelfTests
    {
        [TestMethod()]
        public void ProductExceptSelfTest()
        {
            int[] nums = new int[] { 1, 2, 3, 4 };
            _238_ProductExceptSelf solution = new _238_ProductExceptSelf();
            //输出: [24,12,8,6]
            Assert.AreEqual(24, solution.ProductExceptSelf(nums)[0]);
        }
    }
}