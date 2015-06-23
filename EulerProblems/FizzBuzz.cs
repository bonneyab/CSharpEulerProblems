using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace EulerProblems {
    //For fun?
    public class FizzBuzz {
        public List<string> CalculateFizzBuzz(int total)
        {
            Func<int, string> fizz = f => f%3 == 0 ? "Fizz" : "";
            Func<int, string> buzz = b => b%5 == 0 ? "Buzz" : "";
            Func<int, string> fizzBuzz = f => fizz(f) + buzz(f);
            Func<int, string> fizzBuzzOrNumber = f => string.IsNullOrEmpty(fizzBuzz(f)) ? f.ToString() : fizzBuzz(f);

            var fizzBuzzes = Enumerable.Range(1, total).Select(fizzBuzzOrNumber).ToList();
            fizzBuzzes.ForEach(f => Debug.WriteLine(f));
            return fizzBuzzes;
        }
    }
}
