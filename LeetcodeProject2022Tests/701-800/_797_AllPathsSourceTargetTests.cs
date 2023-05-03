using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._701_800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800.Tests
{
    [TestClass()]
    public class _797_AllPathsSourceTargetTests
    {
        [TestMethod()]
        public void AllPathsSourceTargetTest()
        {
            int[][] graph = ChangeStringToList.GetArrOfArrForInt("[[1, 2],[3],[3],[]]");
            _797_AllPathsSourceTarget solution = new _797_AllPathsSourceTarget();
            //输出：[[0,1,3],[0,2,3]]
            IList<IList<int>> res = solution.AllPathsSourceTarget(graph);
            IList<IList<int>> target = ChangeStringToList.GetIListIListForInt("[[0, 1, 3],[0, 2, 3]]");
            for(int i = 0; i < res.Count; i++)
            {
                for(int j = 0; j < res.Count; j++)
                {
                    Assert.AreEqual(res[i][j], target[i][j]);
                }
            }
        }
    }
}