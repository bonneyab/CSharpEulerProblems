using System;
using System.Linq;
using EulerProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests {
	[TestClass]
	public class Problem9Tests {

		[TestMethod]
		public void GetProductOfPythagoreanTripletForNumber_12_returns60() {
			var problem = new Problem9();

			var actual = problem.GetProductOfPythagoreanTripletForNumber(12);
			Assert.AreEqual(3 * 4 * 5, actual);
		}

		[TestMethod]
		public void GetProductOfPythagoreanTripletForNumber_1000_returns31875000() {
			var problem = new Problem9();

			var actual = problem.GetProductOfPythagoreanTripletForNumber(1000);
			Assert.AreEqual(31875000, actual);
		}
	}
}
