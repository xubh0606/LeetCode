using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._101_200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200.Tests
{
    [TestClass()]
    public class _131_PartitionTests
    {
        [TestMethod()]
        public void PartitionTest()
        {
            _131_Partition soltion = new _131_Partition();
            string s = "aab";
            string[][] board = new string[][] { new string[] { "a", "a", "b" }, new string[] { "aa", "b" } };
            Assert.IsTrue(soltion.Partition(s).Count== board.Length);
        }
    }
}