using System;
using System.Linq;
using System.Numerics;

namespace EulerProblems.Helpers {
	public static class Extensions {
        public static int SumDigits(this double number)
	    {
            var bigInteger = new BigInteger(number);
            var largeNumericString = bigInteger.ToString();
            return largeNumericString.Aggregate(0, (current, next) => current + Convert.ToInt32(next.ToString()));
	    }
	}
}
