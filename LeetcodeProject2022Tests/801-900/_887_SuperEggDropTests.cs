using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._801_900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900.Tests
{
    [TestClass()]
    public class _887_SuperEggDropTests
    {
        [TestMethod()]
        public void SuperEggDropTest()
        {
            int k = 2, n = 6;
            _887_SuperEggDrop solution = new _887_SuperEggDrop();
            Assert.AreEqual(3, solution.SuperEggDrop(k, n));
        }
    }
}