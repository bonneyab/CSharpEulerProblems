using System;
using System.Linq;
using EulerProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests {
	[TestClass]
	public class Problem10Tests {

		[TestMethod]
		public void GetSumOfPrimesBelowNumber_10_returns17() {
			var problem = new Problem10();

			var actual = problem.GetSumOfPrimesBelowNumber(10);
			Assert.AreEqual(17, actual);
		}

		[TestMethod]
		public void GetSumOfPrimesBelowNumber_TwoMillion_returnsSomethingHuge() {
			var problem = new Problem10();

			var actual = problem.GetSumOfPrimesBelowNumber(2000000);
			Assert.AreEqual(142913828922, actual);
		}
	}
}
