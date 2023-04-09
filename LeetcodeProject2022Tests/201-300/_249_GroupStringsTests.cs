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
    public class _249_GroupStringsTests
    {
        [TestMethod()]
        public void GroupStringsTest()
        {
            string[] arrStr = ChangeStringToList.GetStringArray( "[ abc ,  bcd ,  acef ,  xyz ,  az ,  ba ,  a ,  z ]");
            _249_GroupStrings solution = new _249_GroupStrings();
            Assert.AreEqual(4, solution.GroupStrings(arrStr).Count);
        }
    }
}