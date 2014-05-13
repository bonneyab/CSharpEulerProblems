using System;
using System.Collections.Generic;
using EulerProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests {
	[TestClass]
	public class Problem1Tests {
		readonly List<int> _multiples = new List<int>{3, 5};
		[TestMethod]
		public void GetSumOfMultiplesBelowNumber_below10_returns23() {
			var problem1 = new Problem1();
			var actual = problem1.GetSumOfMultiplesBelowNumber(10, _multiples);
			Assert.AreEqual(23, actual);
		}

		[TestMethod]
		public void GetSumOfMultiplesBelowNumber_below1000_returns233168() {
			var problem1 = new Problem1();
			var actual = problem1.GetSumOfMultiplesBelowNumber(1000, _multiples);
			Assert.AreEqual(233168, actual);
		}
	}
}
