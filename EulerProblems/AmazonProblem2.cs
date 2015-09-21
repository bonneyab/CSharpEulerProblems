using System.Linq;

namespace EulerProblems
{
    //A string contains a-z, A-Z and spaces. Sort the string so that all lower cases are at the beginning, spaces in the middle and 
    //upper cases at the end. Original order among lower and upper cases needs to remain the same. For example: a cBd LkmY  becomes 
    //ackm  BLY. Is there a way in O(n) without extra space?</p>
    public class AmazonProblem2
    {
        public string CaseSortedString(char[] text)
        {
            var upperIndex = text.Length - 1;
            var lowerIndex = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (i + 1 > upperIndex)
                    break;
                if (text[i].IsSmall())
                {
                    var temp = text[lowerIndex];
                    text[lowerIndex] = text[i];
                    text[i] = temp;
                    lowerIndex++;
                }
                else if (text[i].IsUpper())
                {
                    var temp = text[upperIndex];
                    text[upperIndex] = text[i];
                    text[i] = temp;
                    upperIndex--;
                    i--;
                }
            }
            return text.Aggregate("", (c, n) => c + n);
        }
    }

    public static class CharExtensions
    {
        public static bool IsSmall(this char c)
        {
            return c >= 97 && c <= 122;
        }

        public static bool IsSpace(this char c)
        {
            return c == 32;
        }

        public static bool IsUpper(this char c)
        {
            return c >= 65 && c <= 90;
        }
    }
}
