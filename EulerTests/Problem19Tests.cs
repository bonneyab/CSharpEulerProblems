using EulerProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests {
	[TestClass]
	public class Problem19Tests {
		[TestMethod]
		public void IsLeapYear_Century_ReturnsFalse()
        {
            var actual = MyOwnDate.IsLeapYear(300);
            Assert.IsFalse(actual);
		}

		[TestMethod]
        public void IsLeapYear_QuadCentury_ReturnsTrue()
        {
            var actual = MyOwnDate.IsLeapYear(800);
            Assert.IsTrue(actual);
		}

        [TestMethod]
        public void IsLeapYear_DivisibleBy4_ReturnsTrue()
        {
            var actual = MyOwnDate.IsLeapYear(8);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsLeapYear_NotDivisibleBy4_ReturnsFalse()
        {
            var actual = MyOwnDate.IsLeapYear(6);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void GetTotalSundays_returns171()
        {
            var problem = new Problem19();
            var actual = problem.GetTotalSundays();
            Assert.AreEqual(171, actual);
        }
	}
}
