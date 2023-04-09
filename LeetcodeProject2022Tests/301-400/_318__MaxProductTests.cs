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
    public class _318__MaxProductTests
    {
        [TestMethod()]
        public void MaxProductTest()
        {
            string[] words = ChangeStringToList.GetStringArray("[  abcw ,  baz ,  foo ,  bar ,  xtfn ,  abcdef ]");
            _318__MaxProduct solution = new _318__MaxProduct();
            Assert.AreEqual(16, solution.MaxProduct(words));
        }
    }
}