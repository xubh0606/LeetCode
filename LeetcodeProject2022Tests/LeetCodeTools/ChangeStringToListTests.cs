using LeetcodeProject2022;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022.LeetCodeTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022.Tests
{
    [TestClass()]
    public class ChangeStringToListTests
    {
        [TestMethod()]
        public void GetStringArrayTest()
        {
            string[] arrS = ChangeStringToList.GetStringArray("[ abc ,  bcd ,  acef ,  xyz ,  az ,  ba ,  a ,  z ]");
            Assert.AreEqual(8, arrS.Length);
        }
    }
}

namespace LeetcodeProject2022.LeetCodeTools.Tests
{
    [TestClass()]
    public class ChangeStringToListTests
    {
        [TestMethod()]
        public void GetIListIListForIntTest()
        {
            string s = "[[1,3,1],[1,5,1],[4,2,1]]";
            Assert.AreEqual(3, ChangeStringToList.GetIListIListForInt(s).Count);
        }
    }
}