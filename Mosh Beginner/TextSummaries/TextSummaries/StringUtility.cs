using System;
using System.Collections.Generic;
using System.Text;

namespace TextSummaries
{
    public class StringUtility
    {
        public static string Summarize(string text, int maxLen = 20)
        {


            if (text.Length < maxLen)
            {
                return text;
            }

            var words = text.Split(' ');
            var totalChar = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalChar += word.Length + 1;
                if (totalChar > maxLen)
                {
                    break;
                }
            }


            return String.Join(" ", summaryWords) + "...";
        }

    }
}
