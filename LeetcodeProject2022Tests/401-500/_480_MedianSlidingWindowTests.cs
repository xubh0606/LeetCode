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
    public class _480_MedianSlidingWindowTests
    {
        [TestMethod()]
        public void MedianSlidingWindowTest()
        {
            int[] nums = new int[] { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;
            _480_MedianSlidingWindow solution = new _480_MedianSlidingWindow();
            double[] res = solution.MedianSlidingWindow(nums, k);
            double[] target = new double[] { 1, -1, -1, 3, 5, 6 };
            Assert.AreEqual(res.Length, target.Length);
            for(int i = 0; i < res.Length; i++)
            {
                Assert.AreEqual(res[i], target[i]);
            }
        }

        [TestMethod()]
        public void MedianSlidingWindow_OutRangeTest()
        {
            int[] nums = new int[] { 1, 2, 3, 4, 2, 3, 1, 4, 2};
            int k = 3;
            _480_MedianSlidingWindow solution = new _480_MedianSlidingWindow();
            double[] res = solution.MedianSlidingWindow(nums, k);
            double[] target = new double[] { 2, 3, 3, 3, 2, 3, 2 };
            Assert.AreEqual(res.Length, target.Length);
            for (int i = 0; i < res.Length; i++)
            {
                Assert.AreEqual(res[i], target[i]);
            }
        }

        [TestMethod()]
        public void MedianSlidingWindow_OutRangeTest2()
        {
            int[] nums = new int[] { 1, 2 };
            int k = 1;
            _480_MedianSlidingWindow solution = new _480_MedianSlidingWindow();
            double[] res = solution.MedianSlidingWindow(nums, k);
            double[] target = new double[] { 1, 2 };
            Assert.AreEqual(res.Length, target.Length);
            for (int i = 0; i < res.Length; i++)
            {
                Assert.AreEqual(res[i], target[i]);
            }
        }
    }
}