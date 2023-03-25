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
    public class _202_IsHappyTests
    {
        [TestMethod()]
        public void IsHappyTest()
        {
            _202_IsHappy solution = new _202_IsHappy();
            Assert.IsTrue(solution.IsHappy(10));
        }
    }
}