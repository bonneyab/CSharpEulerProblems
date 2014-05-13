using EulerProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests {
	[TestClass]
	public class Problem2Tests {
		[TestMethod]
		public void GetSumOfEvenFibonacciNumbersBelowNumber_below100_returns44() {
			var problem2 = new Problem2();
			var actual = problem2.GetSumOfEvenFibonacciNumbersBelowNumber(100);
			Assert.AreEqual(44, actual);
		}
	}
}
