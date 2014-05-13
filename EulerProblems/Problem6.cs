using System;
using System.Linq;

namespace EulerProblems {
	//The sum of the squares of the first ten natural numbers is,
	//12 + 22 + ... + 102 = 385
	//The square of the sum of the first ten natural numbers is,
	//(1 + 2 + ... + 10)2 = 552 = 3025
	//Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
	//Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
	public class Problem6 {

		public int GetDifferenceBetweenSumOfSquaresAndSquareOfSums(int number) {
			return SquareOfSumBelowNumber(number) - SumOfSquaresBelowNumber(number);
		}

		private int SquareOfSumBelowNumber(int number) {
			var sum = Enumerable.Range(1, number).Sum();

			return (int)Math.Pow(sum, 2);
		}

		private int SumOfSquaresBelowNumber(int number) {
			return Enumerable.Range(1, number).Aggregate(0, (current, next) => current + (int)Math.Pow(next, 2));
		}
	}
}
