using System.Linq;
using EulerProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests {
	[TestClass]
	public class StringPermutationsTests {

		[TestMethod]
		public void Permute_abc_returnsStrings() {
			var permutor = new StringPermutations();
			var actual = permutor.Permute("abcd").ToList();
			Assert.AreEqual(24, actual.Count());
		}
	}
}
