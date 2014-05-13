using EulerProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests {
	[TestClass]
	public class Problem3Tests {
		[TestMethod]
		public void GetLargestPrimeFactor_ValidNumber_returnsLargestPrime() {
			var problem3 = new Problem3();
			var actual = problem3.GetLargestPrimeFactor(13195);
			Assert.AreEqual(29, actual);
		}
	}
}
