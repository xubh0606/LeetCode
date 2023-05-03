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
    public class _294_CanWinTests
    {
        [TestMethod()]
        public void CanWinTest()
        {
            string s = "+++++";
            _294_CanWin solution = new _294_CanWin();
            Assert.IsFalse(solution.CanWin(s));
        }
    }
}