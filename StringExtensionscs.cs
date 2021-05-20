using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    public static class StringExtensions
    {
        public static string ToTitleCase(this string s)
        {
            var upperCase = s.ToUpper();
            var words = upperCase.Split(' ');
            var minorWords = new String[] {"ON", "IN", "AT", "OFF", "UP", "TO","OF", "AS", "BY",//prepositions
                                   "THE", "A",  "AN",//articles
                                   "AND", "BUT", "OR", "NOR","YET", "FOR", "SO"};//conjunctions
           
            for (int i = 0; i < words.Length; i++)
            {
                if (minorWords.Contains(words[i]))
                {
                    words[i] = words[i].ToLower();
                }
                else
                {
                    words[i] = words[i].ToPascalCase();
                }
            }
            return string.Join(" ", words);

        }
        public static string ToPascalCase(this string s)
        {
            return s.Substring(0, 1).ToUpper() + s.Substring(1).ToLower();
        }
    }
}
