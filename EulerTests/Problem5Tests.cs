using EulerProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests {
	[TestClass]
	public class Problem5Tests {
		[TestMethod]
		public void GetSmallestNumberDivisibleByNumbers_ValidNumber10_returns2520() {
			var problem = new Problem5();
			var actual = problem.GetSmallestNumberDivisibleByNumbers(10);
			Assert.AreEqual(2520, actual);
		}

		[TestMethod]
		public void GetSmallestNumberDivisibleByNumbers_ValidNumber20_returns() {
			var problem = new Problem5();
			var actual = problem.GetSmallestNumberDivisibleByNumbers(20);
			Assert.AreEqual(232792560, actual);
		}
	}
}
