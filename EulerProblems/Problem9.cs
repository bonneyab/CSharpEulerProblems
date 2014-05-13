using System;

namespace EulerProblems {
	//	A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
	//a2 + b2 = c2
	//For example, 32 + 42 = 9 + 16 = 25 = 5^2.
	//There exists exactly one Pythagorean triplet for which a + b + c = 1000.
	//Find the product abc.
	//Should probably be b < c and a < b in the loops
	public class Problem9 {
		public int GetProductOfPythagoreanTripletForNumber(int number) {
			for (var c = number; c > 0; c--) {
				for (var b = 0; b <  number; b++) {
					for (var a = 0; a < number; a++) {
						if (c + b + a == number && c > b && b > a) {
							if (IsPythagoreanTriplet(a, b, c)) {
								return c*a*b;
							}
						}
					}
				}
			}
			return 0;
		}

		public bool IsPythagoreanTriplet(int a, int b, int c) {
			return (int)Math.Pow(a, 2) + (int)Math.Pow(b, 2) == (int)Math.Pow(c, 2);
		}
	}
}
