using System.Collections.Generic;
using System.Linq;

namespace EulerProblems {
	public class StringPermutations {
		public IEnumerable<string> Permute(string word) {
			if (word.Length > 1) {
				var character = word[0];
				foreach (var sub in Permute(word.Substring(1))) {
					for (var index = 0; index <= sub.Length; index++) {
						var pre = sub.Substring(0, index);
						var post = sub.Substring(index);
						if (post.Contains(character))
							continue;

						yield return pre + character + post;
					}
				}
			}
			else {
				yield return word;
			}
		}
	}
}
