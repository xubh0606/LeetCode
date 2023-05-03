using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022.Tests
{
    [TestClass()]
    public class _518_ChangeTests
    {
        [TestMethod()]
        public void ChangeTest()
        {
            int amount = 5;
            int[] coins = new int[] { 1, 2, 5 };
            _518_Change solution = new _518_Change();
            Assert.AreEqual(4, solution.Change(amount, coins));
        }
    }
}