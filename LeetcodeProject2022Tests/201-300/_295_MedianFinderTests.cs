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
    public class _295_MedianFinderTests
    {
        [TestMethod()]
        public void _295_MedianFinderTest()
        {
            _295_MedianFinder medianFinder = new _295_MedianFinder();
            medianFinder.AddNum(1);    // arr = [1]
            medianFinder.AddNum(2);    // arr = [1, 2]
            medianFinder.FindMedian(); // 返回 1.5 ((1 + 2) / 2)
            medianFinder.AddNum(3);    // arr[1, 2, 3]
            medianFinder.FindMedian(); // return 2.0
        }
    }
}