﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerProblems {
	//The sequence of triangle numbers is generated by adding the natural numbers. So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. The first ten terms would be:
	//1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
	//Let us list the factors of the first seven triangle numbers:
	// 1: 1
	// 3: 1,3
	// 6: 1,2,3,6
	//10: 1,2,5,10
	//15: 1,3,5,15
	//21: 1,3,7,21
	//28: 1,2,4,7,14,28
	//We can see that 28 is the first triangle number to have over five divisors.
	//What is the value of the first triangle number to have over five hundred divisors?
	public class Problem12 {
		public int GetFirstTriangleNumberWithNumberOfDivisors(int numberOfDivisors) {
			var currentDivisors = 0;
			//Lowest possible number with that many divisors
			var index = 0;//Math.Pow(2, numberOfDivisors)
			var triangleNumber = 0;
			while (currentDivisors < numberOfDivisors) {
				triangleNumber = GetTriangleNumber(index);
				currentDivisors = GetDivisors(triangleNumber).Count();
				index++;
			}
			return triangleNumber;
		}

		public int GetTriangleNumber(int number) {
			return number * (number+1)/2;
		}

		public IEnumerable<int> GetDivisors(int number) {
			return Enumerable.Range(1, number).Where(i => IsDivisor(i, number));
		}

		public bool IsDivisor(int divisor, int number) {
			return number%divisor == 0;
		}
	}
}
