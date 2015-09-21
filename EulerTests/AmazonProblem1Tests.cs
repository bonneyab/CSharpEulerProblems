using EulerProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests
{
    [TestClass]
    public class AmazonProblem1Tests
    {
        [TestMethod]
        public void AmazonSequence_Returns_231213_for_3()
        {
            var problem1 = new AmazonProblem1();
            var actual = problem1.AmazonSequence(3);
            Assert.AreEqual("2 3 1 2 1 3", actual);
        }
    }
}
