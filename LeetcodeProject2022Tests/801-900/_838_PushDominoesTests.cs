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
    public class _838_PushDominoesTests
    {
        [TestMethod()]
        public void PushDominoesTest()
        {
            string s = ".L.R...LR..L..";
            _838_PushDominoes solution = new _838_PushDominoes();
            Assert.AreEqual(s.Length, solution.PushDominoes(s).Length);
        }
    }
}