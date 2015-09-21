using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;

namespace EulerProblems
{
    //Write the code to read in characters from a file and print out the top 10 most used. What if they are 32 bit
    //characters? What if it’s a 4GB file and you only have 1GB of ram?
    public class AmazonProblem3
    {
        //so this could run out of memory on a big file
        public IEnumerable<KeyValuePair<char, int>> GetCommonCharacters(string filePath)
        {
            var text = File.ReadAllText(filePath);
            var counts = text.ToCharArray().GroupBy(c => c).Select(c => new KeyValuePair<char, int>(c.Key, c.Count()));
            var top10 = counts.OrderByDescending(c => c.Value).Take(10);
            return top10;
        }

        public IEnumerable<KeyValuePair<char, int>> GetCommonCharactersInChunks(string filePath)
        {
            File.OpenRead(filePath).Read();
            var text = File.ReadAllText(filePath);
            var counts = text.ToCharArray().GroupBy(c => c).Select(c => new KeyValuePair<char, int>(c.Key, c.Count()));
            var top10 = counts.OrderByDescending(c => c.Value).Take(10);
            return top10;

        }
    }
}
