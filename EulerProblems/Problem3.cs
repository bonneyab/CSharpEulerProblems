using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerProblems {
	//The prime factors of 13195 are 5, 7, 13 and 29.

	//What is the largest prime factor of the number 600851475143 ?
	//Could this be rewritten to use a range and an Aggregate?
	public class Problem3 {
		public long GetLargestPrimeFactor(long number) {
			if (number < 1) {
				throw new ArgumentException("there are no prime numbers less than 1");
			}

			var divisibleBy = new List<int>();
			for (var i = 2; i <= number; i++) {
				if (number%i == 0) {
					divisibleBy.Add(i);
					number = number/i;
				}
			}
			return divisibleBy.Max();
		}
	}
}
