using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._401_500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500.Tests
{
    [TestClass()]
    public class _432_AllOneTests
    {
        [TestMethod()]
        public void _432_AllOneTest()
        {

            _432_AllOne allOne = new _432_AllOne();
            allOne.Inc("hello");
            allOne.Inc("goodbye");
            allOne.Inc("hello");
            allOne.Inc("hello");
            allOne.GetMaxKey();
            allOne.Inc("leet");
            allOne.Inc("code");
            allOne.Inc("leet");
            allOne.Dec("hello");
            allOne.Inc("leet");
            allOne.Inc("leet");
            allOne.Inc("code");
            allOne.GetMaxKey();
        }
    }
}