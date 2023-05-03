using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetcodeProject2022;

namespace LeetcodeProject2022._1_100.Tests
{
    [TestClass()]
    public class _79ExistTests
    {
        [TestMethod()]
        public void ExistTest()
        {
            string s = "[[ A ,  B ,  C ,  E ],[ S ,  F ,  C ,  S ],[ A ,  D ,  E ,  E ]]";
            char[][] c = ChangeStringToCharArr.GetCharArr(s);
            _79Exist solution = new _79Exist();
            Assert.IsTrue(solution.Exist(c, "ABCCED"));
        }
    }
}