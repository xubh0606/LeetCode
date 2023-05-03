using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._501_600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._501_600.Tests
{
    [TestClass()]
    public class _582_KillProcessTests
    {
        [TestMethod()]
        public void KillProcessTest()
        {
            IList<int> pid = ChangeStringToList.GetIListForInt("[1, 3, 10, 5]");
            IList<int> ppid = ChangeStringToList.GetIListForInt("ppid = [3, 0, 5, 3]");
            int kill = 5;
            _582_KillProcess solution = new _582_KillProcess();
            Assert.AreEqual(5, solution.KillProcess(pid, ppid, kill)[0]);
            Assert.AreEqual(10, solution.KillProcess(pid, ppid, kill)[1]);
        }
    }
}