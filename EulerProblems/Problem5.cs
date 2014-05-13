using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerProblems {
	//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
	//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
	public class Problem5 {
		public int GetSmallestNumberDivisibleByNumbers(int number) {
			var factors = new Dictionary<int, int>();
			for (var i = 2; i <= number; i++) {
				var currentFactors = GetFactorCounts(i);
				foreach (var currentFactor in currentFactors) {
					MergeFactors(currentFactor, factors);
				}
			}
			//We use the power because some factors occur more than once - so 2^2 represents the factor 2 twice.
			return factors.Aggregate(1, (current, factor) => current*(int) Math.Pow(factor.Key, factor.Value));
		}

		private static void MergeFactors(KeyValuePair<int, int> currentFactor, Dictionary<int, int> factors) {
			var curentValue = currentFactor.Value;
			var key = currentFactor.Key;
			if (factors.ContainsKey(key)) {
				if (factors[key] < curentValue) {
					factors[key] = curentValue;
				}
			}
			else {
				factors.Add(key, curentValue);
			}
		}

		public Dictionary<int, int> GetFactorCounts(int number) {
			var factors = new Dictionary<int, int>();
			for (var i = 2; i <= number; i++) {
				if (number%i != 0) {
					continue;
				}
				if (factors.ContainsKey(i)) {
					factors[i]++;
				}
				else {
					factors.Add(i, 1);
				}
				number /= i;
				i--;
			}
			return factors;
		}
	}
}
