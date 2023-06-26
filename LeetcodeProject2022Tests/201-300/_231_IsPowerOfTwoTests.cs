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
    public class _231_IsPowerOfTwoTests
    {
        [TestMethod()]
        public void IsPowerOfTwoTest()
        {
            int n = 3;
            _231_IsPowerOfTwo solution = new _231_IsPowerOfTwo();
            Assert.IsFalse(solution.IsPowerOfTwo(n));
        }
    }
}