using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022.LeetCodeTools.Tests
{
    [TestClass()]
    public class ChangeStringToCharArrTests
    {
        [TestMethod()]
        public void GetCharArrTest()
        {
            string s = "[[ A ,  B ,  C ,  E ],[ S ,  F ,  C ,  S ],[ A ,  D ,  E ,  E ]]";
            char[][] c = ChangeStringToCharArr.GetCharArr(s);
            Assert.AreEqual(3, c.Length);
        }
    }
}