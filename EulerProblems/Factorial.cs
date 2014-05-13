using System;
using System.Linq;

namespace EulerProblems {
	//A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
	//Find the largest palindrome made from the product of two 3-digit numbers.
	public class Factorial {
		public static Func<int, int> FactorialAnonymous = x => x < 0 ? -1 : x == 1 || x == 0 ? 1 : x * FactorialAnonymous(x - 1);

		public int FactorialRecursive(int number) {
			if (number < 0)
				return -1;
			if (number < 2)
				return 1;

			return number*FactorialRecursive(number - 1);
		}

		public int FactorialAggregate(int number) {
			if (number < 1)
				return -1;
			return Enumerable.Range(1, number).Aggregate((current, next) => current * next);
		}

		public int FactorialStandard(int number) {
			if (number < 0)
				return -1;
			var result = number;
			for (var i = 2; i < number; i++) {
				result *= i;
			}
			return result;
		}
	}
}
