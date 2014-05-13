using System.Linq;
using EulerProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests {
	[TestClass]
	public class Problem14Tests {
		[TestMethod]
		public void GetCollatzTerms_13_returns10() {
			var problem = new Problem14();

			var actual = problem.GetCollatzTerms(13);
			Assert.AreEqual(10, actual);
		}

		[TestMethod]
		public void GetCollatzTerms_837799_returns525() {
			var problem = new Problem14();

			var actual = problem.GetCollatzTerms(837799);
			Assert.AreEqual(525, actual);
		}

		[TestMethod]
		public void GetLongestCollatzSequenceUnderNumber_1000000_returns10() {
			var problem = new Problem14();

			var actual = problem.GetLongestCollatzSequenceUnderNumber(1000000);
			Assert.AreEqual(837799, actual);
		}
	}
}
