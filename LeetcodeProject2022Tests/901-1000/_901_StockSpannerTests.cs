using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._901_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._901_1000.Tests
{
    [TestClass()]
    public class _901_StockSpannerTests
    {
        [TestMethod()]
        public void _901_StockSpannerTest()
        {
            _901_StockSpanner stockSpanner = new _901_StockSpanner();
            stockSpanner.Next(100); // 返回 1
            stockSpanner.Next(80);  // 返回 1
            stockSpanner.Next(60);  // 返回 1
            stockSpanner.Next(70);  // 返回 2
            stockSpanner.Next(60);  // 返回 1
            stockSpanner.Next(75);  // 返回 4 ，因为截至今天的最后 4 个股价 (包括今天的股价 75) 都小于或等于今天的股价。
            stockSpanner.Next(85);  // 返回 6
        }
    }
}