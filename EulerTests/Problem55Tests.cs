using EulerProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests
{
    [TestClass]
    public class Problem55Tests
    {
        [TestMethod]
        public void LychrelNumbersBelow_10000_returns()
        {
            var problem = new Problem55();

            var actual = problem.GetLychrelNumbersBelowValue(10000, 50);
            Assert.AreEqual(249, actual);
        }
    }
}