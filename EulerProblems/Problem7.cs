using EulerProblems.Helpers;

namespace EulerProblems {
	//By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
	//What is the 10 001st prime number?
	public class Problem7 {
		public int FindPrimeNumber(int number) {
			var index = 1;
			var numberToTest = 0;
			while (index <= number) {
				numberToTest++;
				if (PrimeNumberHelper.IsPrime(numberToTest)) {
					index++;
				}
			}
			return numberToTest;
		}
	}
}
