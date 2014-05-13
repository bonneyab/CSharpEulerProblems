using System;
using System.Collections.Generic;

namespace EulerProblems {
	//The following iterative sequence is defined for the set of positive integers:

	//n → n/2 (n is even)
	//n → 3n + 1 (n is odd)

	//Using the rule above and starting with 13, we generate the following sequence:

	//13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
	//It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

	//Which starting number, under one million, produces the longest chain?

	//NOTE: Once the chain starts the terms are allowed to go above one million.
	public class Problem14 {
		readonly Dictionary<long, int> _computedTerms = new Dictionary<long, int>();

		public int GetLongestCollatzSequenceUnderNumber(int number) {
			var maxCount = 0;
			var maxNumber = 0;
			while (number > 1) {
				var count = (int)GetCollatzTerms(number);
				if (count > maxCount) {
					maxCount = count;
					maxNumber = number;
				}
				number--;
			}
			return maxNumber;
		}

		public long GetCollatzTerms(long number) {
			if (number < 1) {
				throw new InvalidOperationException("Cannot retrieve terms for a number less than 1");
			}
			var originalNumber = number;
			var total = 1;
			while (number > 1) {
				if (_computedTerms.ContainsKey(number)) {
					_computedTerms.Add(originalNumber, total - 1 + _computedTerms[number]);
					return total - 1 + _computedTerms[number];
				}
				if (number%2 == 0) {
					number = number/2;
					total++;
				}
				else {
					number = number * 3 + 1;
					total++;
				}
			}
			_computedTerms.Add(originalNumber, total);
			return total;
		}
	}
}
