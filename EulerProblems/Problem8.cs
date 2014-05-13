using System.Collections.Generic;
using System.Linq;

namespace EulerProblems {
	//Find the greatest product of five consecutive digits in the 1000-digit number.
	public class Problem8 {
		public int GetLargestProductInListByConsecutiveDigits(List<int> listOfNumbers, int digits) {
			var result = 0;
			for (var i = 0; i < listOfNumbers.Count() - digits; i++) {
				var product = listOfNumbers.GetRange(i, digits).Aggregate((current, next) => current * next);
				if (product > result) {
					result = product;
				}
			}
			return result;
		}
	}
}
