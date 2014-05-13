using EulerProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests {
	[TestClass]
	public class Problem6Tests {
		[TestMethod]
		public void GetDifferenceBetweenSumOfSquaresAndSquareOfSums_Ten_returnsCorrectValue() {
			var problem = new Problem6();
			var actual = problem.GetDifferenceBetweenSumOfSquaresAndSquareOfSums(10);
			Assert.AreEqual(2640, actual);
		}

		[TestMethod]
		public void GetDifferenceBetweenSumOfSquaresAndSquareOfSums_OneHundred_returnsCorrectValue() {
			var problem = new Problem6();
			var actual = problem.GetDifferenceBetweenSumOfSquaresAndSquareOfSums(100);
			Assert.AreEqual(25164150, actual);
		}
	}
}
