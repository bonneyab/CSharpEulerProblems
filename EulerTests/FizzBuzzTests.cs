using EulerProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests {
	[TestClass]
	public class FizzBuzzTests {

		[TestMethod]
		public void FizzBuzz_100() {
			var problem = new FizzBuzz();

			var actual = problem.CalculateFizzBuzz(100);
			Assert.AreEqual(actual.Count, 100);
		}
	}
}
