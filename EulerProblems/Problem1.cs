using System.Collections.Generic;
using System.Linq;

namespace EulerProblems {
	//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
	//Find the sum of all the multiples of 3 or 5 below 1000.
	public class Problem1 {
		//In retrospect, this would be cleaner with a filter and a empty sum.
		public int GetSumOfMultiplesBelowNumber(int number, List<int> multiples) {
			return Enumerable.Range(1, number - 1).Sum(i => {
				return multiples.Any(m => i % m == 0) ? i : 0;
				//haha!
			});
		}
	}
}
