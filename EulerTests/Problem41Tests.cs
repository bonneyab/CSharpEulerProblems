using EulerProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests
{
    [TestClass]
    public class Problem41Tests
    {
        [TestMethod]
        public void GetLargestPandigitalPrimeForDigits_returns7652413()
        {
            var problem = new Problem41();

            var actual = problem.GetLargestPandigitalPrimeForDigits();
            Assert.AreEqual(7652413, actual);
        }
    }
}