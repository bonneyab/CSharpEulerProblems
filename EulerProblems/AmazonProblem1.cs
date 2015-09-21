using System;
using System.Linq;

namespace EulerProblems
{
    //<p>This is one of the interview questions during the Amazon SDE interview. Request your help in providing the solution.
    //<br>Question - We are interested in building a special type of sequence. for a given number N, we want to arrange the numbers {1,1,2,2,3,3,... N,N} such that they have the following property.
    //<br>For each number / in (1,N) there should be exactly / numbers between the first appearance of the number and the second appearance. Below example would clarify further.
    //<br>Input:
    //<br>A Single number N for which we want to produce the sequence.
    //<br>Output:
    //<br>A space separated list of sequence or NA if there is no possible sequence.
    //<br>Example Input:
    //<br>3
    //<br>Example Output:
    //<br>2 3 1 2 1 3
    //<br>Explanation : There is 1 number between 1s(2). There are 2 numbers between the 2's(3 1 ). There are 3 numbers between the 3's(1 2 1 ).</p>

    public class AmazonProblem1
    {
        public string AmazonSequence(int number)
        {
            var items = new int [number*2];
            var firstAnswer = string.Empty;
            Action<int> amazonSequence = null;
            amazonSequence = (n) =>
            {
                foreach (var i in Enumerable.Range(0, items.Length - n - 1))
                {
                    if (n == 0)
                    {
                        firstAnswer = items.Aggregate("", (current, next) => current + " " + next);
                    }

                    if (items[i] != 0 || items[i + n + 1] != 0) continue;
                    items[i] = n;
                    items[i + n + 1] = n;
                    amazonSequence(n - 1);
                    items[i] = 0;
                    items[i + n + 1] = 0;
                }
            };

            amazonSequence(number);
            return string.IsNullOrEmpty(firstAnswer) ? "NA" : firstAnswer.Trim();
        }
    }
}
