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
    public class _362_HitCounterTests
    {
        [TestMethod()]
        public void _362_HitCounterTest()
        {

            _362_HitCounter counter = new _362_HitCounter();
            counter.Hit(1);// 在时刻 1 敲击一次。
            counter.Hit(2);// 在时刻 2 敲击一次。
            counter.Hit(3);// 在时刻 3 敲击一次。
            counter.GetHits(4);// 在时刻 4 统计过去 5 分钟内的敲击次数, 函数返回 3 。
            counter.Hit(300);// 在时刻 300 敲击一次。
            counter.GetHits(300); // 在时刻 300 统计过去 5 分钟内的敲击次数，函数返回 4 。
            counter.GetHits(301); // 在时刻 301 统计过去 5 分钟内的敲击次数，函数返回 3 。
        }
    }
}