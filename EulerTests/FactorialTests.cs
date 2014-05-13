using EulerProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests {
	[TestClass]
	public class FactorialTests {
		[TestMethod]
		public void FactorialRecursive_GivenValidNumber_ReturnsFactorial() {
			var problem = new Factorial();
			var actual = problem.FactorialRecursive(10);
			Assert.AreEqual(3628800, actual);
		}

		[TestMethod]
		public void FactorialAggregate_GivenValidNumber_ReturnsFactorial() {
			var problem = new Factorial();
			var actual = problem.FactorialAggregate(10);
			Assert.AreEqual(3628800, actual);
		}

		[TestMethod]
		public void FactorialStandard_GivenValidNumber_ReturnsFactorial() {
			var problem = new Factorial();
			var actual = problem.FactorialStandard(10);
			Assert.AreEqual(3628800, actual);
		}

		[TestMethod]
		public void FactorialAnonymous_GivenValidNumber_ReturnsFactorial() {
			var actual = Factorial.FactorialAnonymous(10);
			Assert.AreEqual(3628800, actual);
		}
	}
}
