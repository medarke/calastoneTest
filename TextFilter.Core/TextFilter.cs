using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextFilter.Core
{
    public static class TextFilter
    {
        public static string GetMiddleOfString(string word)
        {
            if (!string.IsNullOrEmpty(word))
            {
                var offset = word.Length % 2 == 0 ? 1 : 0;
                var middle = word.Substring(word.Length / 2 - offset, offset + 1);

                return middle;
            }
            return string.Empty;
        }

        public static bool ContainsVowel(string word)
        {
            return word.Where(c => "aeiouAEIOU".Contains(c)).Distinct().Any();
        }

      
        public static string RemoveSymbols(string lineInput)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9 ]");
            lineInput = rgx.Replace(lineInput, " ").Replace("  ", " ");

            return lineInput;

        }
    }
}
