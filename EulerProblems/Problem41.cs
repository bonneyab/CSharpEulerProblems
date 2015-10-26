using System;
using System.Collections.Generic;
using System.Linq;
using EulerProblems.Helpers;

namespace EulerProblems
{
    //Pandigital prime
    //Problem 41
    //We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once. For example, 2143 is a 4-digit pandigital and is also prime.
    //What is the largest n-digit pandigital prime that exists?
    public class Problem41
    {
        //would probably work but not enough memory not to mention rather inefficient
        //public int GetLargestPandigitalPrimeBelowNumber(int number = 987654322)
        //{
        //    var primes = PrimeNumberHelper.GetPrimeNumbersBelowNumber(number);
        //    Func<int, bool> isPandigital = i =>
        //    {
        //        var digits = new Dictionary<string, int>();
        //        Enumerable.Range(1, 9)
        //            .Select(e => new KeyValuePair<string, int>(e.ToString(), 0))
        //            .ToList().ForEach(e => digits.Add(e.Key, e.Value));

        //        i.ToString().ToCharArray().ToList().ForEach(c => digits[c.ToString()] = digits[c.ToString()] + 1);
        //        return digits.All(d => d.Value < 2);
        //    };
        //    return primes.Where(isPandigital).Max();
        //}

        public int GetLargestPandigitalPrimeForDigits(string digits = "987654321")
        {
            var primes = new List<int>();
            while (primes.Count == 0)
            {
                var results = StringPermutations.Permute(digits).Select(r => Convert.ToInt32(r)).ToList();
                primes = results.Where(r => PrimeNumberHelper.IsPrime(r)).ToList();
                digits = digits.Substring(1);
            }
            return primes.Max();
        }
    }
}