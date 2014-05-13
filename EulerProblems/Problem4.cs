using System;
using System.Linq;

namespace EulerProblems {
	//A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
	//Find the largest palindrome made from the product of two 3-digit numbers.
	public class Problem4 {
		public int GetLargestPalindromicNumber(int digits) {
			if (digits < 1) {
				throw new ArgumentException("there must be at least one digit");
			}

			var start = 9;
			//pretty sure this is silly, consider something like 10^digits
			while (start.ToString().Length < digits) {
				start = AddDigit(start);
			}

			var biggestPalindrome = 0;
			//Change this to consider the sum of the numbers that landed you at the current biggest, this would take far fewer iterations.
			for (var i = start; i > 0; i--) {
				for (var j = start; j > 0; j--) {
					var current = i*j;
					if (IsPalindromic(current) && current > biggestPalindrome) {
						biggestPalindrome = current;
					}
				}
			}

			return biggestPalindrome;
		}

		private static int AddDigit(int start) {
			return start * 10 + 9;
		}

		public static bool IsPalindromic(int number) {
			var s = number.ToString();
			return s ==  new string(s.Reverse().ToArray());
		}
	}
}
