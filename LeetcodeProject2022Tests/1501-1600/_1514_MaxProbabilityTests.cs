using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1501_1600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600.Tests
{
    [TestClass()]
    public class _1514_MaxProbabilityTests
    {
        [TestMethod()]
        public void MaxProbabilityTest()
        {
            double[] succProb = new double[] { 0.5, 0.5, 0.2 };
            int n = 3, start = 0, end = 2;
            int[][] edges = ChangeStringToList.GetArrOfArrForInt("[[0, 1],[1,2],[0,2]]");
            _1514_MaxProbability solution = new _1514_MaxProbability();
            Assert.AreEqual(0.25, solution.MaxProbability(n, edges, succProb, start, end));
        }

        [TestMethod()]
        public void MaxProbabilityTest2()
        {
            double[] succProb = new double[] {0.06, 0.26, 0.49, 0.25, 0.2, 0.64, 0.23, 0.21, 0.77 };
            int n = 5, start = 0, end = 3;
            int[][] edges = ChangeStringToList.GetArrOfArrForInt("[[2,3],[1,2],[3,4],[1,3],[1,4],[0,1],[2,4],[0,4],[0,2]]");
            _1514_MaxProbability solution = new _1514_MaxProbability();
            Assert.AreEqual(0.25, solution.MaxProbability(n, edges, succProb, start, end));
        }

        [TestMethod()]
        public void MaxProbabilityTest3()
        {
            double[] succProb = new double[] { 0.37, 0.17, 0.93, 0.23, 0.39, 0.04};
            int n = 5, start = 3, end = 4;
            int[][] edges = ChangeStringToList.GetArrOfArrForInt("[[1,4],[2,4],[0,4],[0,3],[0,2],[2,3]]");
            _1514_MaxProbability solution = new _1514_MaxProbability();
            Assert.AreEqual(0.25, solution.MaxProbability(n, edges, succProb, start, end));
        }
    }
}