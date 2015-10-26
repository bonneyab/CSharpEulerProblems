using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerProblems.Helpers {
	class PrimeNumberHelper {
		public static bool IsPrime(long number) {
			if (number < 2)
				return false;

			for (var i = 2; i < number; i++) {
				if (number % i == 0) {
					return false;
				}
			}
			return true;
		}

		public static List<int> GetPrimeNumbersBelowNumber(int number) {
			var numbers = new Dictionary<int, bool>();
			for (var i = 2; i <= number; i++) {
				numbers.Add(i, true);
			}

			for (var i = 2; i < Math.Ceiling(Math.Pow(number, .5)) + 1; i++) {
				if (!numbers[i]) {
					continue;
				}
				var current = Math.Pow(i, 2);
				var counter = 1;
				while (current <= number) {
					numbers[(int)current] = false;
					current = Math.Pow(i, 2) + i*counter;
					counter ++;
				}
			}
			return numbers.Where(n => n.Value).Select(n => n.Key).ToList();
		}
	}
}
