using System;
using System.Linq;
using System.Numerics;
using EulerProblems.Helpers;

namespace EulerProblems {
	//2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

	//What is the sum of the digits of the number 2^1000?
	public class Problem16 {
		public int GetSumOfDigitsForTwoTothePowerOfNumber(int power) {
			var result = Math.Pow(2, power);
		    return result.SumDigits();
		}
	}
}
