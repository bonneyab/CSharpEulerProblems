using EulerProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests {
	[TestClass]
	public class Problem7Tests {
		[TestMethod]
		public void FindPrimeNumber_6_returns13() {
			var problem = new Problem7();
			var actual = problem.FindPrimeNumber(6);
			Assert.AreEqual(13, actual);
		}

		[TestMethod]
		public void FindPrimeNumber_10001_returns104743() {
			var problem = new Problem7();
			var actual = problem.FindPrimeNumber(10001);
			Assert.AreEqual(104743, actual);
		}
	}
}
