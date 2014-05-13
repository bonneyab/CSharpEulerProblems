using System.Linq;
using EulerProblems.Helpers;

namespace EulerProblems {
	//The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
	//Find the sum of all the primes below two million.
	public class Problem10 {
		public double GetSumOfPrimesBelowNumber(int number) {
			return PrimeNumberHelper.GetPrimeNumbersBelowNumber(number).Aggregate<int, double>(0, (current, i) => current + i);
		}
	}
}
