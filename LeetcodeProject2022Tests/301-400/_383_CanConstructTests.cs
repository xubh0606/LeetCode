using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._301_400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400.Tests
{
    [TestClass()]
    public class _383_CanConstructTests
    {
        [TestMethod()]
        public void CanConstructTest()
        {
            string ransomNote = "a", magazine = "b";
            _383_CanConstruct solution = new _383_CanConstruct();
            Assert.IsFalse(solution.CanConstruct(ransomNote, magazine));
        }
    }
}