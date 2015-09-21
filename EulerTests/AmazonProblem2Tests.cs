using EulerProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests
{
    [TestClass]
    public class AmazonProblem2Tests
    {
        [TestMethod]
        public void CaseSortedString_Returns_sortedString()
        {
            var problem1 = new AmazonProblem2();
            var actual = problem1.CaseSortedString("a cBd LkmY  ".ToCharArray());
            Assert.AreEqual("ackm  BLY", actual);
        }
    }
}
