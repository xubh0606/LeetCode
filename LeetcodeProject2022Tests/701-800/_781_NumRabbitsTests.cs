using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._701_800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800.Tests
{
    [TestClass()]
    public class _781_NumRabbitsTests
    {
        [TestMethod()]
        public void NumRabbitsTest()
        {
            int[] answers = new int[] { 10, 10, 10 };
            _781_NumRabbits solution = new _781_NumRabbits();
            Assert.AreEqual(11, solution.NumRabbits(answers));
        }
    }
}