using EulerProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests
{
    [TestClass]
    public class Problem50Tests
    {
        [TestMethod]
        public void ConsecutivePrimeSum_100_returns41()
        {
            var problem = new Problem50();

            var actual = problem.ConsecutivePrimeSum(100);
            Assert.AreEqual(41, actual);
        }

        [TestMethod]
        public void ConsecutivePrimeSum_1000_returns953()
        {
            var problem = new Problem50();

            var actual = problem.ConsecutivePrimeSum(1000);
            Assert.AreEqual(953, actual);
        }

        [TestMethod]
        public void ConsecutivePrimeSum_1000000_returnsX()
        {
            var problem = new Problem50();

            var actual = problem.ConsecutivePrimeSum(1000000);
            Assert.AreEqual(953, actual);
        }
    }
}