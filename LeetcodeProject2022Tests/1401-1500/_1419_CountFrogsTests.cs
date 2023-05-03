using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1401_1500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1401_1500.Tests
{
    [TestClass()]
    public class _1419_CountFrogsTests
    {
        [TestMethod()]
        public void MinNumberOfFrogsTest()
        {
            string croakOfFrogs = "croakcroak";
            _1419_CountFrogs solution = new _1419_CountFrogs();
            Assert.AreEqual(1, solution.MinNumberOfFrogs(croakOfFrogs));
        }
    }
}