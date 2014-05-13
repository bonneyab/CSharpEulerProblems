using EulerProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests {
	[TestClass]
	public class Problem16Tests {
		[TestMethod]
		public void GetSumOfDigitsForTwoTothePowerOfNumber_15_returns26() {
			var problem = new Problem16();

			var actual = problem.GetSumOfDigitsForTwoTothePowerOfNumber(15);
			Assert.AreEqual(26, actual);
		}

		[TestMethod]
		public void GetSumOfDigitsForTwoTothePowerOfNumber_1000_returns1366() {
			var problem = new Problem16();

			var actual = problem.GetSumOfDigitsForTwoTothePowerOfNumber(1000);
			Assert.AreEqual(1366, actual);
		}
	}
}
