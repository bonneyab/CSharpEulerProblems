﻿using EulerProblems;
using EulerProblems.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests {
	[TestClass]
	public class Problem4Tests {
		[TestMethod]
		public void GetLargestPalindromicNumber_TwoDigits_ReturnsLargestPalindromicNumber() {
			var problem = new Problem4();
			var actual = problem.GetLargestPalindromicNumber(2);
			Assert.AreEqual(9009, actual);
		}

		[TestMethod]
		public void GetLargestPalindromicNumber_ThreeDigits_ReturnsLargestPalindromicNumber() {
			var problem = new Problem4();
			var actual = problem.GetLargestPalindromicNumber(3);
			Assert.AreEqual(906609, actual);
		}

		[TestMethod]
		public void IsPalindromic_IsPaladrome_returnsTrue() {
			Assert.IsTrue(9009.IsPalindromic());
		}

		[TestMethod]
		public void IsPalindromic_IsNotPalindrome_returnsFalse() {
			Assert.IsFalse(123.IsPalindromic());
		}
	}
}
