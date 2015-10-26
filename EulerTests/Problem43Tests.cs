using EulerProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests
{
    [TestClass]
    public class Problem43Tests
    {
        [TestMethod]
        public void GetDivisiblePanDigitalNumberSum_returns7652413()
        {
            var problem = new Problem43();

            var actual = problem.GetDivisiblePanDigitalNumberSum();
            Assert.AreEqual(16695334890.0, actual);
        }
    }
}