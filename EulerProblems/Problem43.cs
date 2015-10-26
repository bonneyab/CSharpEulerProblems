using System;
using System.Collections.Generic;
using System.Linq;
using EulerProblems.Helpers;

namespace EulerProblems
{
    //The number, 1406357289, is a 0 to 9 pandigital number because it is made up of each of the digits 0 to 9 in some order, but it also has a rather interesting sub-string divisibility property.

    //Let d1 be the 1st digit, d2 be the 2nd digit, and so on. In this way, we note the following:

    //d2d3d4=406 is divisible by 2
    //d3d4d5=063 is divisible by 3
    //d4d5d6=635 is divisible by 5
    //d5d6d7=357 is divisible by 7
    //d6d7d8=572 is divisible by 11
    //d7d8d9=728 is divisible by 13
    //d8d9d10=289 is divisible by 17
    //Find the sum of all 0 to 9 pandigital numbers with this property.
    public class Problem43
    {

        public double GetDivisiblePanDigitalNumberSum(string digits = "9876543210")
        {
            var results = StringPermutations.Permute(digits).Select(Convert.ToDouble)
                .Where(d => TestValue(d.ToString())).ToList();
            return results.Sum();
        }

        private bool TestValue(string digits)
        {
            var lowPrimes = new List<int>
            {
                2, 3, 5, 7, 11, 13,17
            }; 
            var i = 1;
            foreach (var lowPrime in lowPrimes)
            {
                string value = new string(digits.Skip(i).Take(3).ToArray());
                var current = Convert.ToInt32(value);
                if (current%lowPrime != 0)
                    //I could remove everything that contains this triplet at this point but all the looping might actually be slower?
                    return false;
                i++;
            }
            return true;
        }
    }
}