using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100.Tests
{
    [TestClass()]
    public class _51_SolveNQueensTests
    {
        [TestMethod()]
        public void SolveNQueensTest()
        {
            _51_SolveNQueens sloution = new _51_SolveNQueens();
            //4行4列时有2种情况，6行4列也有4种
            Assert.AreEqual(2, sloution.SolveNQueens(4).Count);
            Assert.AreEqual(6, sloution.SolveNQueens(6).Count);
        }
    }
}