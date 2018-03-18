using System.Collections.Generic;
using System.Text;

namespace lab1.Extensions {
    public static class StringExtension {
        private static StringBuilder builder = null;
        private static HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

        private static void AppendCharToBuilder(char c) {
            builder.Append(c);
            if (vowels.Contains(c)) {
                builder.Append(c);
            }
        }

        public static string DoubleVowels(this string str) {
            builder = new StringBuilder();
            foreach(char c in str) {
                AppendCharToBuilder(c);
            }

            return builder.ToString();
        }
    }
}