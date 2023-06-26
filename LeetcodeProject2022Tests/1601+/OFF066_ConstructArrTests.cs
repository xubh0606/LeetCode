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
    public class OFF066_ConstructArrTests
    {
        [TestMethod()]
        public void ConstructArrTest()
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5 };
            OFF066_ConstructArr solution = new OFF066_ConstructArr();
            Assert.AreEqual(5, solution.ConstructArr(nums).Length);
        }
    }
}