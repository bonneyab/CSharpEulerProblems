﻿using System;
using System.Globalization;
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
        
	    public static bool IsPalindromic(this int number)
	    {
	        var s = number.ToString();
	        return s == new string(s.Reverse().ToArray());
	    }

	    public static bool IsPalindromic(this double number)
	    {
	        var bigInteger = new BigInteger(number);
            var s = bigInteger.ToString();
	        return s == new string(s.Reverse().ToArray());
	    }
    }
}
