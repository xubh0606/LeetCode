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
    public class _254_GetFactorsTests
    {
        [TestMethod()]
        public void GetFactorsTest()
        {
            int n = 12;
            _254_GetFactors solution = new _254_GetFactors();
            Assert.AreEqual(3, solution.GetFactors(n).Count);
        }
    }
}