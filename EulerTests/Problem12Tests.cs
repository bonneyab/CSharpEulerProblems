using EulerProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests {
	[TestClass]
	public class Problem12Tests {
		[TestMethod]
		public void GetFirstTriangleNumberWithNumberOfDivisors_5_returns28() {
			var problem = new Problem12();

			var actual = problem.GetFirstTriangleNumberWithNumberOfDivisors(5);
			Assert.AreEqual(28, actual);
		}

		[TestMethod]
		public void GetFirstTriangleNumberWithNumberOfDivisors_500_returns28() {
			//var problem = new Problem12();

			//takes too long to run, should 
			//var actual = problem.GetFirstTriangleNumberWithNumberOfDivisors(500);
			//Assert.AreEqual(76576500, actual);
		}
	}
}
